using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp;

internal class Vetores_Simultaneo
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        int quarto = int.Parse(Console.ReadLine());
        double preco = double.Parse(Console.ReadLine());

        string[] vet = Console.ReadLine().Split(' ');
        string lastname = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com seu nome completo: ");
        Console.WriteLine(nome);
        Console.WriteLine("Quantos quartos tem sua casa? ");
        Console.WriteLine(quarto);
        Console.WriteLine("Entre com o preço de um produto: ");
        Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Entre com seu ultimo nome, idade e altura");
        Console.WriteLine(lastname);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}
