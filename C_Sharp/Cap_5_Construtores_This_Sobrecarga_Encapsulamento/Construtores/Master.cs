using System;
using System.Globalization;

namespace Construtores_This_Sobrecarga_Encapsulamento.Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dessa forma, ao instânciar a classe, podemos declarar diretamente ao criar o produto.
             
            Propriedades p = new Propriedades("TV", 500.00, 15);
            Console.WriteLine(p); 
            */

            //Entrada de dados inseridos pelo utilizador, seguido da instanciação para armazenar os mesmos;
            Console.WriteLine("Entre os dados do produto:");

            // Como temos que entrar com os dados do produto primeiro para depois o instânciar,
            // Vamos seguir a lógica de usar variáveis auxiliares para o processo;
            // Criar uma var nome, preco, quantidade, só para receber o valor que o usuário digitar, seria como uma variável temporária, que só vai servir para tal
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, quantidade);
            Console.WriteLine(p);

            /*
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */
        }
    }
}