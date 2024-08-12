using /* diretorio da entidade ... */

    class Program
{
    static void Main(string[] args)
    {
        Client a = new Client { Name = "Maria", Email = "maria@gmail.com"}
        Client b = new Client { Name = "Alex", Email = "maria@gmail.com" }

        //Como a valida��o � pelo e-mail, logo ser� verdadeiro
        Console.WriteLine(a.Equals(b));

        Client a = new Client { Name = "Maria", Email = "maria@gmail.com" }
        Client b = new Client { Name = "Alex", Email = "alex@gmail.com" }

        //Como a valida��o � pelo e-mail, logo ser� falso
        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());

        /* 
         Ter aten��o as compara��es de igualdade, pois deste modo,
         estamos a comparar apenas a refer�ncia do endere�o de mem�ria para tal objeto
         */
        Console.WriteLine(a == b);
    }
}