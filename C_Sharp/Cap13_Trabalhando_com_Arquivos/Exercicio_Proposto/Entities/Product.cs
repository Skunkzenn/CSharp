namespace Exercicio_Trabalhando_Arquivos.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qntity { get; set; }
      
        public Product(string nome, double preco, int qntidade)
        {   
            Name = nome;
            Price = preco;
            Qntity = qntidade;
        }

        public double Total()
        {
            return Qntity * Price;
        }
    }

   
}
