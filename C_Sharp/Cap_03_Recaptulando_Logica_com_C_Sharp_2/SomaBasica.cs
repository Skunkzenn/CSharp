using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp;

internal class SomaBasica
{
    static void Main(string[] args)
    {
        /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos. */

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int soma;

        soma = a + b;
        Console.WriteLine("Soma: " + soma);

    }
}
