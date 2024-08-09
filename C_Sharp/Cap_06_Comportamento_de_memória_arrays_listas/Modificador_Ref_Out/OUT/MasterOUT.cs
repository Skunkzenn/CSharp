using System;


class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int triple;

                           //Passamos a variável original e a variável que vai armazenar o resultado, que será a var de saída
        Calculator.Triple(a, out triple);
        Console.WriteLine(triple);

    }
}
