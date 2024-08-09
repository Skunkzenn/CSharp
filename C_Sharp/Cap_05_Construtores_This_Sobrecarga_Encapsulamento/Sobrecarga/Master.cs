using System.Globalization;
using Sobrecarga;

namespace Construtores_This_Sobrecarga_Encapsulamento.Sobrecarga
{
    internal class Master
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //Para utilizar a sobrecarga, basta seguir os padroes de entrada
            //Como temos um metódo apenas com duas entradas
            //Usamos o mesmo para referencias chamando a classe
            Produto1 p = new Produto1(nome, preco);


            //Podemos usar o construtor padrão, sem nada 
            Produto1 p2 = new Produto1();
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Dados do produto: " + p2);
        }
    }
}
