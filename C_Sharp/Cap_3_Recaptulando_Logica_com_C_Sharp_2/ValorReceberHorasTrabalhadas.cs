using System;
using System.Globalization;

namespace Projetos_CSharp
{
    internal class ValorReceberHorasTrabalhadas
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. 
            * A seguir, mostre o número e o salário do funcionário, com duas casas decimais. */

            int cod = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double receber;

            receber = (double)horas * (double)valorH;

            Console.WriteLine("Number: " + cod);
            Console.WriteLine("Salário: " + receber.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
