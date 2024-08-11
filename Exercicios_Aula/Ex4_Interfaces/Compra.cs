using System.Globalization;
namespace Ex4_Interfaces;

class Compra : IPagamento
{
    public double ValorTotal { get; set; }
    public string Fornecedor { get; set; }
    public Compra() { }
    public Compra(double valorTotal, string fornecedor) {  
        ValorTotal = valorTotal;
        Fornecedor = fornecedor; 
    }

    public double CalcularPagamento(int qnt, double valorUn) {  
        return ValorTotal += qnt * valorUn; 
    }

    public double ProcessarPagamento(double desconto)
    {
        desconto = (desconto / 100);
        return ValorTotal -= (ValorTotal * desconto) ;
    }

    public override string ToString()
    {
        return $"Nome Fornecedor: {Fornecedor}, Valor Total: {ValorTotal.ToString("F2", CultureInfo.InvariantCulture)}";
    }

}
