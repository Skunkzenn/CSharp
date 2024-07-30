using System;
using System.Globalization;

/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). */

namespace aulas_udemy;

internal class Exercicios
{
    static void Main(string[] args)
    {
        /* Fazer um programa para ler um número N. 
         * Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. 
         * Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". */

        int repeticoes = int.Parse(Console.ReadLine());

        for (int i = 0; i < repeticoes; i++)
        {
            string[] vetores = Console.ReadLine().Split(' ');
            double valor1 = double.Parse(vetores[0], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(vetores[1], CultureInfo.InvariantCulture);

            if (valor2 != 0)
            {
                double divisao = valor1 / valor2;
                Console.WriteLine(divisao.ToString("F1"));
            }
            else
            {
                Console.WriteLine("Impossível Dividir");
            }
        }


    }
}