using System;
using System.Globalization;


namespace aulas_udemy;

internal class Exercicios
{
    static void Main(string[] args)
    {
        /* Ler um número inteiro N e calcular todos os seus divisores. */

        int divisor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= divisor; i++)
        {
            if (divisor % i == 0)
            {
                int resultado = i;
                Console.WriteLine(resultado);
            }
        }
    }

}
