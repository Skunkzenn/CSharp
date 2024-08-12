using /* diretorio da entidade ... */

    class Program
{
    static void Main(string[] args)
    {
        Client a = new Client { Name = "Maria", Email = "maria@gmail.com"}
        Client b = new Client { Name = "Alex", Email = "maria@gmail.com" }

        //Como a validação é pelo e-mail, logo será verdadeiro
        Console.WriteLine(a.Equals(b));

        Client a = new Client { Name = "Maria", Email = "maria@gmail.com" }
        Client b = new Client { Name = "Alex", Email = "alex@gmail.com" }

        //Como a validação é pelo e-mail, logo será falso
        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());

        /* 
         Ter atenção as comparações de igualdade, pois deste modo,
         estamos a comparar apenas a referência do endereço de memória para tal objeto
         */
        Console.WriteLine(a == b);
    }
}