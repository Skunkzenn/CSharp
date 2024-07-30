namespace Exercicio1;

class Program
{
    public static void Main(string[] args)
    { 
        
        Product product1 = new Product("TV", 900.00, 2);
        Product product2 = new Product("Mouse", 80.00, 1);
        Product product3 = new Product("Teclado", 100.00, 5);

        Product.listProduct.Add(product1);
        Product.listProduct.Add(product2);
        Product.listProduct.Add(product3);

        foreach (Product product in Product.GetListProduct()) {
            Console.WriteLine(product);
        }



    }
}
