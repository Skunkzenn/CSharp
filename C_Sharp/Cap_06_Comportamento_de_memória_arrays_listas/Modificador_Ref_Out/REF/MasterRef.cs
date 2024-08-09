class Program
{
    static void Main(string[] args)
    {
        int a = 10;      //Neste ponto também será necessário utilizar o ref para referenciar a função   
        Calculator.Triple(ref a);
        Console.WriteLine(a);
    }