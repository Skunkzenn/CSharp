using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não .*/

namespace Projetos_CSharp;

internal class NegativoOuPositivo
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        if (a >= 0) Console.WriteLine("Positivo");
        else Console.WriteLine("Negativo");
    }
}
