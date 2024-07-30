using System.Globalization;
/*Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.*/
namespace Exercicios_C_;

class ContaBancaria
{                           //nº da conta nao pode ser alterado
    public int Numero { get; private set; }
    public string Titular {  get; set; }
    //Saldo em conta so pode ser alterado por meio de operações
    public double Saldo {  get; private set; }

    public ContaBancaria(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
    }


    public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
    {   
        //É mais viavel chamar o método Deposito cá dentro pois é esse o método que gere a conta, ou seja, para manuntenções e segurança. Pois se de hoje para amanha a operação Deposito mudar a operacao ContaBancaria tambem ficara atualizada. 
        Deposito(depositoInicial);
    }
    //Será void poorque simplesmente o valor vai ser alterado na memória. Entender bem essa lógica.
    public void Deposito(double quantia)
    {
        Saldo += quantia;
    }

    public void Saque(double quantia)
    {
        Saldo -= quantia + 5.00;
    }

    public override string ToString()
    {
        return "Conta " + Numero + ", Titular: " + Titular + "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }

    
}