using System;

namespace Coursing;

class Master
{
    static void Main(string[] args)
    {
        Propriedades produto = new Propriedades("TV", 900.00, 10);

        produto.Nome = "TV 4K";
        //Nao vai permitir alterar o valor do preço, pensar assim: SOMENTE LEITURA!!!!
        produto.Preco = 10;

        Console.WriteLine(produto.Nome);
        Console.Write(produto.Preco);

    }
}