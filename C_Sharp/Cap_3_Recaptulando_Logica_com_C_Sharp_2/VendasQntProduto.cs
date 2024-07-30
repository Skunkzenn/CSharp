using System;
using System.Globalization;

namespace Projetos_CSharp;

internal class VendasQntProduto
{
    static void Main(string[] args)
    {
        /* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar. */

        string[] vetores = Console.ReadLine().Split(' ');
        int cod = int.Parse(vetores[0]);
        int qnt = int.Parse(vetores[1]);
        double preco;


        if (cod == 1) {
            preco = 4 * (double)qnt;
            Console.WriteLine($"Cod: {cod}, Especificação: Cachorro Quente, Preço: {preco.ToString("F2", CultureInfo.InvariantCulture)}."); 
        } if (cod == 2) {
            preco = 4.5 * (double)qnt;
            Console.WriteLine($"Cod: {cod}, Especificação: X-Bacon, Preço: {preco.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
        if (cod == 3)
        {
            preco = 5 * (double)qnt;
            Console.WriteLine($"Cod: {cod}, Especificação: X-Calabresa, Preço: {preco.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
        if (cod == 4)
        {
            preco = 2 * (double)qnt;
            Console.WriteLine($"Cod: {cod}, Especificação: Torradas com Anananás, Preço: {preco.ToString("F2", CultureInfo.InvariantCulture)}");
        } else if (cod == 5)
        {
            preco = 2 * (double)qnt;
            Console.WriteLine($"Cod: {cod}, Especificação: Refrigerante, Preço: {preco.ToString("F2", CultureInfo.InvariantCulture)}");
        } else if(cod == 0 || cod > 6) { Console.WriteLine("Error de digitação, tente novamente"); } 

    }
}
