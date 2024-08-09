using System;

using System.Globalization;

namespace aulas_udemy;

internal class Exercicios
{
    static void Main(string[] args)
    {
        /* Ler um valor N. Calcular e escrever seu respectivo fatorial. 
         * Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
         * Lembrando que, por definição, fatorial de 0 é 1. */

        double fatorial = fatorial = double.Parse(Console.ReadLine());
        //Nº natural já começa em 1
        int fat = 1;

        //Ou seja vai rodar o nº d vezes socilitado pelo utilizador
        for (int i = 1; i <= fatorial; i++)
        {
            //Começa com valor 1 e multiplica pelo primeiro indice da operação
            //Pex: Fatorial 3
            // * Primeiro Loop:entra com 1(fat) * 1 da primeira repetição;
            // * Segundo Loop: entra com 1(valor fa) * 2(segunda repetição) ;
            // * Terceiro Loop: entra com 2(valor anterior) * 3(terceira repetição);
            // * Racicionar como realizar esse tipo de método!
            fat = fat * i;
        }

        Console.WriteLine(fat);
    }

}

