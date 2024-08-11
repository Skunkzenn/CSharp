namespace Working_with_files.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
    }
}
