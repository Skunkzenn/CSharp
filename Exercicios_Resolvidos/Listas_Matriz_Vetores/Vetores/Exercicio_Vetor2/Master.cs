using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course;

class Master
{
    static void Main(string[] args)
    {                       //Criamos o vector de tamanho 10 e instânciar para assim ele iniciar todos os quartos com os valores vazios
        Estudante[] vect = new Estudante[10];

        Console.Write("Quantos quartos você quer alugar? ");
        int n = int.Parse(Console.ReadLine());

        //Passamos o valor de n inserido pelo utilziador para definir o tamanho do loop.
        for (int i = 1; i <= n; i++)
        {   //Vai imprimir o primeiro índice do aluguel
            Console.WriteLine($"Aluguel #{i}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            int quarto = int.Parse(Console.ReadLine());
            //Aqui passa o valor do quarto registrado para dentro do vetor de tamanho 10, ou seja, irá armazenar na posição que o utilizador passar como parâmetro
            ////Como declaramos o vetor, membro da classe Estudante, passando o valor do quarto para o vetor, criando assim, um novo estudante
            vect[quarto] = new Estudante(nome, email);
        }

        Console.WriteLine();
        Console.WriteLine("Quartos ocupados:");

        for (int i = 1;i <= 10; i++) {
            //Se o vector na posição do índice for diferente de null, ele vai imprimir normalmente, se for null, passa a frente, até concluir todo o ciclo for dos 10 QUARTOS.
            if (vect[i] != null) {
            Console.WriteLine(i + ": " + vect[i]);
            }

        }

    }
}
