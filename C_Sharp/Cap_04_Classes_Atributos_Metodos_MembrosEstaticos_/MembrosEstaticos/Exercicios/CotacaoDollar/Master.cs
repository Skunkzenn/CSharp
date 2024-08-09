using AutoPropriedades_;
using System.Globalization;

namespace Exercicios_C_
{
    class Master
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double precoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double compDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorFinal = ConversorDeMoeda.PagamentoDollar(precoDolar, compDolar);
            Console.WriteLine($"Valor a ser pago em reais = {valorFinal.ToString("F2")}", CultureInfo.InvariantCulture);
        }
    }
}
