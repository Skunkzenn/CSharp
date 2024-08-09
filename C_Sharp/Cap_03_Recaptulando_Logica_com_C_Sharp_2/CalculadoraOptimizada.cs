using System;
using System.Globalization;

namespace Projetos_CSharp;

internal class CalculadoraOptimizada
{
    static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 números");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Calculadora(n1, n2);
            Console.WriteLine("Resultado: " + resultado.ToString("F2"));

        }

        static double Calculadora(double num1, double num2)
        {
            double resultado = 0;
            Console.WriteLine("Digite a operação.");
            string operacao = Console.ReadLine();

            switch (operacao)
            {
                case "sum":
                    resultado = num1 + num2; break;

                case "sub":
                    resultado = num1 - num2; break;

                case "mult":
                    resultado = num1 * num2; break;

                case "div":
                    if (num2 == 0) throw new DivideByZeroException();
                    else resultado = num1 / num2; break;

                default: Console.WriteLine("Erro de digitação"); break;
            }
            return resultado;
        }
    }
}
