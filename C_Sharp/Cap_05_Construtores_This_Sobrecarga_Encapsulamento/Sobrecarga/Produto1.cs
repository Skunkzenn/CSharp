/* Sobrecarga
 
    • É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com diferentes listas deparâmetros.

*/



namespace Sobrecarga;


class Produto1
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    //Exemplo de sobrecarga
    /*  Adicionar produtos ao estoque, informando a quantidade,
     *  Outra hora a quantidade e a data que foram adicionados, 
     *  Entao vamos ter duas versoes da adicionar produtos e o que vai variar entre elas é a lista de parâmetros;
     */


   /* 
    * Proposta de melhoria
        • Vamos criar um construtor opcional, o qual recebe apenas nome e preço do produto.
        * A quantidade em estoque deste novo produto, por padrão, deverá então ser iniciada com o valor zero.
        • Nota: é possível também incluir um construtor padrão (sem parâmetros) 
   */

    //Construtor Padrão (Sem parâmetros de entrada)
public Produto1()
{
}
public Produto1(string nome, double preco, int quantidade)
{
    Nome = nome;
    Preco = preco;
    Quantidade = quantidade;
}
    //Construtor Opcional
public Produto1(string nome, double preco)
{
    Nome = nome;
    Preco = preco;
        //Como na proposta de melhoria o novo produto criado, deverá ter por padrão, a quantidade deverá ser inciada com o valor de 0; 
        //Vale ressaltar que por padrão da linguagem, valores já começam em 0.
        //Só colocamos o valor a 0 para ficar didático;
        //Podemos tbm alterar o valor de um atributo, pex: um produto no armazem já inicia com 5 unidades
    Quantidade = 0;
}
}

