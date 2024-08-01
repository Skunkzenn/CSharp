using System.Globalization;

namespace Exercise_Enumeracoes_Composicoes_com_UML.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name 
                + ", $" 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Quantity: " + Quantity 
                + ", Subtotal: $" 
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
