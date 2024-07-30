using System;
using System.Globalization;

namespace Projetos_CSharp;

/* Leia um valor inteiro X(1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso. */

static void Main(string[] args)
{
    int valorX = int.Parse(Console.ReadLine());

    for (int i = 1; i <= valorX; i++)
    {

        if (i % 2 != 0)
        {
            Console.WriteLine($"Valor #{i}");
        }
    }
}

