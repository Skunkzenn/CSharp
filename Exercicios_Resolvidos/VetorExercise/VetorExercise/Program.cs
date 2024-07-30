using System;
using System.Globalization;

namespace VetorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] aluno = new Estudante[10];
            
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                aluno[quarto] = new Estudante(nome, email);
                Console.WriteLine();
            }


            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if(aluno[i] != null)
                {
                    Console.WriteLine($"{i}: {aluno[i]}");
                }
            }

        }
    }
}