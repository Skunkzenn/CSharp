using System;
using System.Globalization;

/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
   código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago. */

namespace Projetos_CSharp
{
    internal class CalcSellerDiferentsProducts
    {
        static void Main(string[] args)
        {
   
        int codPeca1 = int.Parse(Console.ReadLine());
        int qntPeca1 = int.Parse(Console.ReadLine());
        double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int codPeca2 = int.Parse(Console.ReadLine());
        int qntPeca2 = int.Parse(Console.ReadLine());
        double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double valorPagar = (double)(qntPeca1 * valor1) + (double)(qntPeca2 * valor2);

        Console.WriteLine("Valor a pagar: " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
