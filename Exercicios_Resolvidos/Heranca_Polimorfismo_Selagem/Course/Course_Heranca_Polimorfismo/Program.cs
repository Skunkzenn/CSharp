/* 
 * Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). 
 * Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.
 * Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação.
 * Estes dados específicos devem ser acrescentados na etiqueta de preço conforme exemplo (próxima página). 
 * Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto.
 * Favor implementar o programa conforme diagrama UML. 
*/

using System.Globalization;
using Course_Heranca_Polimorfismo.Entities;

namespace Course_Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numProd = int.Parse(Console.ReadLine());

            for (int i = 0; i < numProd; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char mode = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (mode == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new ImportedProduct(name, price, customsFee);
                    products.Add(product);
                }
                else if (mode == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manFactureDate = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct(name, price, manFactureDate);
                    products.Add(product);
                }
                else if (mode == 'c')
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                else
                {
                    Console.WriteLine("Incorrect format.");
                }
            }

            foreach (Product product in products)
            {
                Console.WriteLine("PRICE TAGS:");
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
