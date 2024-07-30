using System;

namespace ExercicioVetor;

class Vetor
{
    static void Main(string[] args)
    {
        Console.Write("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());

        /* 
         * Passar parâmetro de entrada 'n', que tem o controle da qnt de inserção.
         * Instanciar objeto para depois determinar valores
         * Valor padrão será null por termos uma referência
         * Quando temos o tamanho do vetor, em classe, referenciamos dentro da instanciação*/

        Alunos[] vector = new Alunos[10]; 

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Aluguel #{i+1}:");
            Console.Write("Nome:");  string name = Console.ReadLine();
            Console.Write("E-mail:");  string email = Console.ReadLine();
            Console.Write("Quarto:"); int quarto = int.Parse(Console.ReadLine());

            vector[quarto] = new Alunos(name, email);
        }

        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");

        for (int i = 0;i <= 9; i++) {
        if (vector[i] != null) {
                Console.WriteLine($"Quarto{i}, {vector[i]}");
            }
        }


    }

}