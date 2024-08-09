using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp
{
    internal class Multiplo_Or_No2
    {
        static void Main(string[] args)
        {
           /* 3) Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
           Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
           ordem crescente ou decrescente. */

            string[] vetores = Console.ReadLine().Split(' ');
            int a = int.Parse(vetores[0]);
            int b = int.Parse(vetores[1]);
            if (a == 0 && b == 0) Console.WriteLine("Impossível Realizar!");
            else if (a % b == 0 || b % a == 0) Console.WriteLine("Múltiplo");
            else Console.WriteLine("Não Múltiplo");
        }
    }
}
