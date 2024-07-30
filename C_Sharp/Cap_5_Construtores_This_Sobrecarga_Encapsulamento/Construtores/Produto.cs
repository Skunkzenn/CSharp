/* 
 * Construtor
 * 
        • É uma operação especial da classe, que executa no momento da instanciação do objeto.

* Usos comuns:
        • Iniciar valores dos atributos. (para que eles nunca comecem null)
        • Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação (injeção de dependência)
        • Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão: 
                Propriedades p = new Propriedades();
        • É possível especificar mais de um construtor na mesma classe (sobrecarga) 

* Quando executamos o comando abaixo, instanciamos um produto "p" com seus atributos “vazios”:
        
        p = new Propriedades();

* Entretanto, faz sentido um produto que não tem nome? Faz sentido um produto que não tem preço?
* Com o intuito de evitar a existência de produtos sem nome e sem preço, é possível fazer com que seja “obrigatória” a iniciação desses valores?

* Ou seja, vai iniciar sempre como nulo e isso não é boa prática de programação. 
* Devemos então ter atenção como declaramos a nossa classe e como a orientamos no cod.
* Entender bem esse conceito vai te ajudar a optmizar o trabalho e assim unificar os próximos conhecimentos.


 */

using System.Globalization;

namespace Construtores_This_Sobrecarga_Encapsulamento.Construtor
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtores ficam sempre depois dos atributos;
        // O construtor é uma operação que tem o mesmo nome da classe e da seguinte forma podemos definir, se nosso construtor terá algum parâmetro de entrada.
        // Dessa forma, na hora de instanciar um produto, seremos obrigados a entrar com um nome, preço e quantidade já no construtor.
        // Atribuindo cada parâmetro que chegar neles, para os atributos.
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}