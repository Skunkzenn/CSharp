using System;
using AluguerQuartos;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[10];

            Console.Write("Quantos quartos serão alugados? ");
            int nQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < nQuartos; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                alunos[quarto] = new Aluno(nome, email);
            }

            for (int i = 0; i < 10; i++)
            {
                if (alunos[i] != null)
                {
                    Console.WriteLine($"{i}: {alunos[i]}");
                }
            }
        }
    }
}