/* 
 * Properties
 * 
 São definições de métodos ENCAPSULADOS, porém expondo uma sintaxe similiar à de atributos e não de métodos.

 */

using System.Globalization;
namespace Coursing;

class Propriedades
{
    private string _nome3;
    private double _preco;
    private int _quantidade;

    public Propriedades(string nome, double preco, int quantidade)
    {
        _nome3 = nome;
        _preco = preco;
        _quantidade = quantidade;
    }
    //Ao inves de criarmos um get.. um set, unificamos tudo nas propriedades, utilizando a mesma logica da implementação dos get e sets, mas de uma forma mais optimizada.
    //Temos o nome privativo como propriedade da classe e usamos a Propriedade a seguir, para expor um caminho para esse nome, assim não se trabalha diratamente com a variável da classe. Mantendo a integridade do código.
    public string Nome
    {
        //Colocamos a operação get para o atributo nome, que será só retornar o nome
        get { return _nome3; }
        set
        {       //utilizando o value, estamos a indicar que o valor(string) será o valor que entrar no método set, ou seja, a string a ser inserida pelo utilizador
            if (value != null && value.Length > 1)
            {
                _nome3 = value;
            }
        }
    }

    //Preço não pode ser alterado, apenas leitura.
    public double Preco3
    {
        get { return _preco; }
    }
    //Quantidade não pode ser alterada, apenas leitura.
    public int Quantidade
    {
        get { return _quantidade; }
    }
    //Valor em estoque, não pode ser alterado, apenas leitura.
    public double ValorTotalEmEstoque
    {
        get { return _preco * _quantidade; }
    }

}