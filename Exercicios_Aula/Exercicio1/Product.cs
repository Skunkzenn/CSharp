using System.Globalization;

namespace Exercicio1
{
    class Product
    {
        public static List<Product> listProduct = new List<Product>();
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmStock { get; set; }

        public Product() { }
        public Product(string nome, double preco, int qnt) { 
            Nome = nome;
            Preco = preco;
            QuantidadeEmStock = qnt;
        }

        public static List<Product> GetListProduct()
        {
           return listProduct;
        }


        public override string ToString()
        {
            return $"{Nome} | {Preco.ToString("F2", CultureInfo.InvariantCulture)} | {QuantidadeEmStock}";
        }


    }
}
