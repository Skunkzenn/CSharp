using Classes;
using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace AutoPropriedades_
{
    class Program
    {
      /*  Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha. */
        static void Main(string[] args)
        {   //Chamar a classe e criar as variáveis
            Dados x, y;
            //Criar a instânciação
            x = new Dados();
            y = new Dados();

            Console.WriteLine("Dados da primeira pessoa:");
            x.nome = Console.ReadLine();
            x.idade = byte.Parse(Console.ReadLine());
            

            Console.WriteLine("Dados da segunda pessoa:");
            y.nome = Console.ReadLine();
            y.idade = byte.Parse(Console.ReadLine());
            

            Console.WriteLine($"Nome: {x.nome}\nIdade: {x.idade}");
            Console.WriteLine($"Nome: {y.nome}\nIdade: {y.idade}");

            if (x.idade > y.idade) Console.WriteLine($"Pessoa mais velha: {x.nome}");
            else if (x.idade < y.idade) Console.WriteLine($"Pessoa mais velha: {y.nome}");
            else Console.WriteLine("Mesma idade");

        }
    }
}