/* Encapsulamento
   
    É um princípio que consiste em esconder detalhes de implementação de um componente, expondo apenas operações seguras e que o matenha em um estado consistente.
   
Regra de ouro: O objeto deve sempre estar em um estado consistente, e a própria classe deve garantir isso.

Opção 1: Implementação manual
* Todo atributo é definido como private(não vai ter mais acesso por outro arquivo)
* Implementa-se métodos Get(obter) e Set(definir) para cada atributo, conforme regras de negócio;
* Nota: não é usual na plataforma C#.
* 
* 
 
 */

using System;
namespace AutoPropriedades_;

class AutoPropriedades
{
    //Um atributo sendo publico, permite que o seus valores sejam alterados e prejudique a integridade do programa, o programador livremente poderia alterar a quantidade.
    //Na linguagem em C# quando vamos trabalhar com um atributo privativo, criamos o nome desse atributo utilizando um _xxxx onde x são as letras minúsculas.
    //Temos de disponibilizar esses dados de alguma forma para o programa, ir para o master;
    public string _nomeproduto;
    private double _precoproduto;
    private int _quantidadeproduto;
    
    //construtor padrão
    public AutoPropriedades(){
    }

    //construtor com 3 argumentos
    public AutoPropriedades(string nome, double preco, int quantidade)
    {
        _nomeproduto = nome;
        _precoproduto = preco;
        _quantidadeproduto = quantidade;
    }
    
    //Metodo para obter o nome do produto;
    public string GetNome(){
        return _nomeproduto;
    }

    public double GetPreco()
    {
        return _precoproduto;
    }

    //No caso se não quisermos que seja alterado os dados do produto, basta criar os métodos somente para Get, ou seja, somente para obter os valores;
    //Dessa forma conseguimos controlar o que será alterado no nosso código.
    public int GetQuantidade() {
        return _quantidadeproduto;
    }

    //E se quisermos alterar o nome do produto? Teremos que utilizar o método Set
    //Porque criar com void? Porque esse método não vai me retornar nada como saída, apenas alterar o valor no endereço de memória
    //Recebe como parâmetro de entrada o nome (que será o valor digitado pelo utilizador)
    public void SetNome(string nome){
                            //O nome.Lenght ira validar o tamanho da string, ou seja, se o tamanho da palavra será maior que uma letra.
                            //Dessa forma, asseguramos que estamos mantendo o estado consistente do nosso objeto, de acordo com a regra de negócio.
        if (nome != null && nome.Length > 1)
        {
            //Lá no atributo nome, ele vai receber o nome que nós colocarmos no parâmetro de entrada
            _nomeproduto = nome;
        }
    }

    public void SetPreco(double preco) {
        _precoproduto = preco;
    }
}
