using Exercicio_Heranca_Polimorfismo.Entities;
using System.Globalization;

List<Product> listProduct = new List<Product>();

Console.Write("Enter the number of products: ");
int numOfReg = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfReg; i++)
{
   
    Console.WriteLine($"Product #{i + 1} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char definition = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (definition == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Product product = new ImportedProduct(name, price, customsFee);
        product.PriceTag();
        listProduct.Add(product);
    }

    else if (definition == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime dateUse = DateTime.Parse(Console.ReadLine());
        Product product = new UsedProduct(name, price, dateUse.Date);
        product.PriceTag();
        listProduct.Add(product);
    }
    else if (definition == 'c')
    {
        Product product = new Product(name, price);
        product.PriceTag();
        listProduct.Add(product);
    }
    else { Console.WriteLine("Incorrect value."); }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach (Product product in listProduct)
{
    Console.WriteLine(product.PriceTag());
}