using System.Text;
using System.Globalization;

namespace ExerciciosRevisao.Entities
{
    class Conta
    {
        public int NumberAcc { get; set; }
        public string NameProp { get; set; }
        public DateTime OpenAcc { get; set; } = new DateTime();
        public double Balance { get; set; }

        public Conta() { }
        public Conta(int numCont, string nameProp, DateTime dateOpen, double balance) {
            NumberAcc = numCont;
            NameProp = nameProp;
            OpenAcc = dateOpen;
            Balance = balance;
        }

        public virtual void Deposit(double deposit)
        {
            Balance += deposit;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {   
            return $"Nº Conta: {NumberAcc}, Nome: {NameProp}, Data Abertura: {OpenAcc.ToString("dd/MM/yyyy")}, Saldo: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
