using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;


namespace aulas_udemy;

internal class Exercicios
{
    static void Main(string[] args)
    {
        /* Fazer um programa para ler um número inteiro positivo N. 
         * O programa deve então mostrar na tela N linhas, começando de 1 até N. 
         * Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo. */

        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int primeiro = i;
            int aoQuadrado = (int)Math.Pow(primeiro, 2);
            int aoCubo = (int)Math.Pow(primeiro, 3);
            Console.WriteLine($"{primeiro}, {aoQuadrado}, {aoCubo}");
        }

    }

}