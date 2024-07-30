using System;

/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar */

namespace Projetos_CSharp;

internal class ParOuImpar
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        //Lembrar que para verificar um número par
        //Devemos calcular o resto da divisão e verficar se o mesmo é igual a 0;

        if (a % 2 == 0) Console.WriteLine("number par");
        else Console.WriteLine("number ímpar");

    } 
}