using System;
using System.Globalization;

/* Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). */

namespace Testes_CSharp;

internal class Program
{
    static void Main(string[] args)
    {

        string[] vetores = Console.ReadLine().Split(' ');
        int valor1 = int.Parse(vetores[0]);
        int valor2 = int.Parse(vetores[1]);

        while (valor1 != 0 && valor2 != 0)
        {

            if (valor1 > 0 && valor2 > 0) Console.WriteLine("Quadrante 1");
            else if (valor1 < 0 && valor2 > 0) Console.WriteLine("Quadrante 2");
            else if (valor1 < 0 && valor2 < 0) Console.WriteLine("Quadrante 3");
            else Console.WriteLine("Quadrante 4");

            //Como já declaramos em cima, nesta parte basta declarar as var, sem às classificar
            vetores = Console.ReadLine().Split(' ');
            valor1 = int.Parse(vetores[0]);
            valor2 = int.Parse(vetores[1]);

        }
        Console.WriteLine("Quadrante nulo, impossível realizar");
    }
}