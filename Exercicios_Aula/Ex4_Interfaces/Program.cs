using Ex4_Interfaces;
using System.Globalization;


class Program
{
    private static void Main(string[] args)
    {
        List<IPagamento> transacoes = new List<IPagamento>();

        /*Compra compra1 = new Compra(0.00, "BilVolts");
        Console.WriteLine(compra1);
        compra1.CalcularPagamento(5, 500.04);
        Console.WriteLine(compra1);
        compra1.ProcessarPagamento(27.5);
        Console.WriteLine(compra1);
        transacoes.Add(compra1);*/

        transacoes.Add(new Compra(500.00, "Joaquim"));
        transacoes.Add(new Venda(800.00, "Kusk"));

        foreach (IPagamento transaco in transacoes)
        {
            Console.WriteLine(transaco);
        }
        Console.WriteLine();

        /*Venda venda1 = new Venda(0.0, "Tio Manel");
        Console.WriteLine(venda1);
        venda1.CalcularPagamento(1, 280.99);
        Console.WriteLine(venda1);
        venda1.ProcessarPagamento(0.23);
        Console.WriteLine(venda1);
        transacoes.Add(venda1);*/

        foreach (IPagamento item in transacoes)
        {
            if (item is Compra compra) {
                compra.CalcularPagamento(1, 800.00);
                compra.ProcessarPagamento(10);
            }
            else if (item is Venda venda) { 
            item.CalcularPagamento(2, 800.00);
            item.ProcessarPagamento(0.23);
            }
        }

        foreach (IPagamento transaco in transacoes)
        {
            Console.WriteLine(transaco);
        }
    }
}