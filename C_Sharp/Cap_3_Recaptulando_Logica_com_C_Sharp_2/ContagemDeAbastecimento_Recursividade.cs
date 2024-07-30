using System;
using System.Globalization;

/* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. 
 * Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 
 * 1.Álcool 
 * 2.Gasolina 
 * 3.Diesel
 * 4.Fim.
 * Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). 
 * O programa será encerrado quando o código informado for o número 4. 
 * Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo. */

namespace Testes_CSharp;

internal class ContagemDeAbastecimento_Recursividade
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite um número entre 1 e 4");
        int numPrinc = int.Parse(Console.ReadLine());
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        while (numPrinc != 4)
        {
            if (numPrinc == 1) alcool = alcool + 1;
            else if (numPrinc == 2) gasolina = gasolina + 1;
            else if (numPrinc == 3) diesel = diesel + 1;

            numPrinc = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("MUITO OBRIGADO!");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");

    }
}