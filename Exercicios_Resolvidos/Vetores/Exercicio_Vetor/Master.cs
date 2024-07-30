

namespace Course;

class Master
{
    static void Main(string[] args)
    {
        //Entender bem a lógica de passar o tamanho do Vetor, já que o temos. (10 quartos)
        Estudante[] vect = new Estudante[10];

        Console.WriteLine("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
                                        //Nesse caso, vai imprimir o indice que estamos, ou seja, o indice 1.
            Console.WriteLine($"Aluguel #{i}:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());

            //Como declaramos o vetor, membro da classe Estudante, passando o valor do quarto para o vetor, criando assim, um novo estudante
            vect[quarto] = new Estudante(name, email);
        }
        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");

        for (int i = 0; i < 10; i++) {
            //Se o vector na posição do índice for diferente de null, ele vai imprimir normalmente, se for null, passa a frente, até concluir todo o ciclo for dos 10 QUARTOS.
            if (vect[i] != null) { 
            Console.WriteLine(i + ": " + vect[i]);
            }
        }

    }
}
