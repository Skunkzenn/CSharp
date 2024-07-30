/* Sobrecarga
• É um recurso que uma classe possui de oferecer mais de uma
operação com o mesmo nome, porém com diferentes listas de
parâmetros.

 Proposta de melhoria
• Vamos criar um construtor opcional, o qual recebe apenas nome e preço do produto. 
A quantidade em estoque deste novo produto, por padrão, deverá então ser iniciada com o valor zero.
• Nota: é possível também incluir um construtor padrão (sem parâmetros)
*/


using System.Globalization;

namespace Construtores_This_Sobrecarga_Encapsulamento.Sobrecarga
{
    internal class Master1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //Outro tipo de instânciação seria de se fazer manualmente a entrada de valores;
            //Essa sintaxe funciona mesmo que a classe não tenha construtores implementados;
            //Para utilizar essa forma mesmo com construtores, basta criar o construtor padrão na classe.
            Produto1 p = new Produto1
            {
                Nome = "TV",
                Preco = 900.0,
                Quantidade = 0
            };
            Produto1 p2 = new Produto1()
            {
                Nome = "TV",
                Preco = 900.0,
                Quantidade = 0
            };

        }
    }
}
