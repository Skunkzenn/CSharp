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
        /* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
         * Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
         * Apresente a média ponderada para cada um destes conjuntos de 3 valores.
         * Sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5. */

        int valorRepete = int.Parse(Console.ReadLine());
        double mediaNotas = 0;

        for (int i = 0; i < valorRepete; i++)
        {

            string[] vetores = Console.ReadLine().Split(' ');
            double nota1 = double.Parse(vetores[0], CultureInfo.InvariantCulture);
            double nota2 = double.Parse(vetores[1], CultureInfo.InvariantCulture);
            double nota3 = double.Parse(vetores[2], CultureInfo.InvariantCulture);

            mediaNotas = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5));
            mediaNotas = (mediaNotas / 10);
            Console.WriteLine(mediaNotas.ToString("F1"));

        }
    }
}
