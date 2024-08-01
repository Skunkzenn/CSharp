using Exercise_Enumeracoes_Composicoes_com_UML.Entities.Enum;
using Exercise_Enumeracoes_Composicoes_com_UML.Entities;
using System.Globalization;

namespace Exercise_Enumeracoes_Composicoes_com_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, dateOfBirth);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int nItems = int.Parse(Console.ReadLine());

            Product product = new Product();
            OrderItem orderItem = new OrderItem();

            for(int i = 0; i < nItems; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                product = new Product(nameProduct, priceProduct);
                orderItem = new OrderItem(quantity, priceProduct, product);

                order.AddItem(orderItem);
            }
            order.Total();

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

        }
    }
}
