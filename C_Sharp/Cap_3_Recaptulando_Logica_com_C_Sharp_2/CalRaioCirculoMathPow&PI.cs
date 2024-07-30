using System;
using System.Globalization;

namespace Projetos_CSharp
{
    internal class CalCirculoMathPow_PI
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos. */

            double pi = (double)Math.PI;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area;

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
