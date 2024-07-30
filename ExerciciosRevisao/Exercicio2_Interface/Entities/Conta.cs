using System.Text;
using System.Globalization;

namespace Exercicio2_Interface.Entities;

class Conta : IOperacoes
{
    private static List<Conta> listBancaria = new List<Conta>();
    public int NumberAcc { get; set; }
    public string NameProp { get; set; }
    public DateTime OpenAcc { get; set; } = new DateTime();
    public double Balance { get; set; }

    public Conta() { }
    public Conta(int numCont, string nameProp, DateTime dateOpen, double balance)
    {
        NumberAcc = numCont;
        NameProp = nameProp;
        OpenAcc = dateOpen;
        Balance = balance;
    }

    public static List<Conta> GetListBank()
    {
        return listBancaria;
    }

    public bool InsertElement(object x)
    {
        if (x is Conta newAcc)
        {
            listBancaria.Add(newAcc);
            return true;
        }
        return false;
    }

    public bool RemoveElement(object x)
    {

        if (x is int accountId)
        {
            Conta accRemove = listBancaria.Find(c => c.NumberAcc == accountId);

            if (accRemove != null)
            {
                listBancaria.Remove(accRemove);
                return true;
            }
        }
        return false;
    }

    public bool UpdateElement(object x)
    {
        // Verificar se o objeto passado é do tipo Conta
        if (x is Conta novaConta)
        {
            // Procurar a conta na lista pelo número da conta
            Conta contaExistente = listBancaria.Find(c => c.NumberAcc == novaConta.NumberAcc);

            // Se a conta existir, atualizar os dados
            if (contaExistente != null)
            {
                contaExistente.NameProp = novaConta.NameProp;
                contaExistente.OpenAcc = novaConta.OpenAcc;
                contaExistente.Balance = novaConta.Balance;
                return true; // Atualização bem-sucedida
            }
        }

        return false; // Conta não encontrada ou objeto não é do tipo Conta
    }

    public List<Conta> SelectElements(Type typeValue, object id)
    {
        if (typeValue == typeof(Conta))
        {
            // Verificar se o identificador é do tipo int (assumindo que o identificador seja o número da conta)
            if (id is int accountId)
            {
                // Retorna a lista filtrada contendo apenas a conta com o número da conta correspondente
                return listBancaria.Where(c => c.NumberAcc == accountId).ToList();
            }
        }
        return null;
    }

    public void Deposit(double deposit)
    {
        Balance += deposit;
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public override string ToString()
    {
        return $"Nº Conta: {NumberAcc}, Nome: {NameProp}, Data Abertura: {OpenAcc.ToString("dd/MM/yyyy")}, Saldo: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
    }

}
