using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp
{
    internal class DifProduto4Valores
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
               de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca;

            diferenca = (a * b - c * d);

            Console.WriteLine("Diferença: " + diferenca);

        }
    }
}
