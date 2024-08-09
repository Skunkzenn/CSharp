using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp
{
    internal class ParOuImpar2
    {
        static void Main(string[] args)
        {
            // 2) Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            
            int inteiro = int.Parse(Console.ReadLine());
            int inteiro2 = int.Parse(Console.ReadLine());

                    if (inteiro % 2 == 0) {
                        Console.WriteLine("Par!");
                    }else { Console.WriteLine("Ímpar!"); }

            Console.WriteLine(inteiro2 % 2 == 0 ? "Par!" : "Ímpar");
            
        }
    }
}
