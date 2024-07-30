using System;

namespace AutoPropriedades_;

class Program
{
    static void Main(string[] args)
    {
        AutoPropriedades produto = new Produto("TV", 900.00, 10);

        //Se mantermos o atributo como public, podemos alterar quando quiser, mas se o definirmos como privado, ficará inacessível.
        //produto.Quantidade = -10;

        //Será uma forma manual de controlar o acesso aos atributos.
        //Vantagens: proteção, o acesso ao atributo por meio de métodos, podemos adicionar uma lógica a esses atributos.
        produto.SetNome("TV 4K");

        //Ira retornar o primeiro valor "TV" pois não cumpre com os requisitos na regra de negocio
        produto.SetNome("T");
        
        //Não vai funcionar, pois apenas é para leitura e não alterações
        produto.SetPreco(500.00);

        //Fazemos o acesso ao método criado para obter o nome do produto referenciado
        Console.WriteLine(produto.GetNome());
        //Fazemos o acesso ao método criado para obter o preço do produto referenciado
        Console.Write(produto.GetPreco());

        //Podemos retornar normalmente a quantidade, mas não alterar
        Console.WriteLine(produto.GetQuantidade());
        produto.GetQuantidade(30);

    }
}