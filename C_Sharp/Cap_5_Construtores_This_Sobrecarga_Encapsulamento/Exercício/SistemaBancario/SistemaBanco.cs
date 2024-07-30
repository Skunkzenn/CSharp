using System.Globalization;
/*Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.*/
namespace Exercicios_C_;

class SistemaBanco
{
    public int Conta { get; private set; }
    private string _nome;
    private double _deposito;


    public SistemaBanco(int conta, string nome) {
        Conta = conta;
        _nome = nome;
    }
    public SistemaBanco(int conta, string nome, double deposito) :this(conta, nome){
        _deposito = deposito;
    }

    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (_nome != null && value.Length >= 6) {
                _nome = value;
            }
        }
    }

    public double PrimeiroDeposito {
        get { 
            return _deposito; 
        }
        set { _deposito = value; }
    }

    public double SegundoDeposito
    {
        get { return _deposito; }
        set
        {
            _deposito += value;
        }
    }

    public double RetirarDinheiro
    {
        get { return _deposito; }
        set { _deposito -= value + 5; }
    }

    public double SaldoEmConta
    {
        get { return _deposito; }
    }

    public override string ToString()
    {
        return $"Conta: {Conta}, Titular: {_nome}, Saldo: {_deposito.ToString("F2", CultureInfo.InvariantCulture)}";
    }

  
}