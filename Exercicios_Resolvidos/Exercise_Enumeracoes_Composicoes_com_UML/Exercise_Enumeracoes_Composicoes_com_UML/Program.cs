using Exercise_Enumeracoes_Composicoes_com_UML.Entities.Enum;
using Exercise_Enumeracoes_Composicoes_com_UML.Entities;

namespace Exercise_Enumeracoes_Composicoes_com_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY)");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, dateOfBirth);
            

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int nItems = int.Parse(Console.ReadLine());

            for(int i = 0; i < nItems; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
            }

        }
    }
}
