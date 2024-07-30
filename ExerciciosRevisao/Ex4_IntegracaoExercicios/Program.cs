/* Exercício 4: Integração dos Exercícios Anteriores
Integre os conceitos de listas, herança e programação em camadas num único projeto. 

Por exemplo:    
       Pode expandir o Exercício 1, onde os contatos são herdados de uma classe base "Pessoa"
       a aplicação a desenvolver utilizar o conceito de programação em camadas. 
                                        (apresentação, lógica de negócios e acesso a dados). */

using Ex4_IntegracaoExercicios;
/*
List<Contatos> listContatos = new List<Contatos>();
Contatos cont1 = new Contatos("Victor", 961723874);
listContatos.Add(cont1);
foreach  (Contatos cont in listContatos)
{
    Console.WriteLine(cont);
}
*/


using System;

class Program
{
    static void Main()
    {
        Negocios negociosApp = new Negocios();

        while (true)
        {
            Console.WriteLine("1. Listar contatos");
            Console.WriteLine("2. Adicionar contato");
            Console.WriteLine("3. Leitura de ficheiro bin");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    negociosApp.ListarContatos();
                    break;

                case "2":
                    Console.Write("Digite o nome do contato: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o telefone: ");
                    int telefone = int.Parse(Console.ReadLine());

                    Contatos novoContato = new Contatos { Nome = nome, NTelefone = telefone };
                    negociosApp.AdicionaContato(novoContato);
                    break;
                case "3":
                    negociosApp.LoadContatos("Ficheiro bin");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
