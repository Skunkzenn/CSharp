using System;

class Program
{
    static void Main()
    {
        BibliotecaApp bibliotecaApp = new BibliotecaApp();

        while (true)
        {
            Console.WriteLine("1. Listar Livros");
            Console.WriteLine("2. Adicionar Livro");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    bibliotecaApp.ListarLivros();
                    break;

                case "2":
                    Console.Write("Digite o título do livro: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Digite o autor do livro: ");
                    string autor = Console.ReadLine();

                    Livro novoLivro = new Livro { Titulo = titulo, Autor = autor };
                    bibliotecaApp.AdicionarLivro(novoLivro);
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
