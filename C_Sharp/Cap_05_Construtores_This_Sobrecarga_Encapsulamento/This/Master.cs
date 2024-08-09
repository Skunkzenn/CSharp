using System.Globalization;
using AutoPropriedades_;

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

            AutoPropriedades p = new Produto(nome, preco);

        }
    }
}