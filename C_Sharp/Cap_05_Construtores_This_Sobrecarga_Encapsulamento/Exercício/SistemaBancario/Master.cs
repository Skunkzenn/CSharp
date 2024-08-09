using Exercicios_C_;
using System;
using System.Globalization;

namespace Course;

class Program
{
    static void Main(string[] args)
    {


        Console.Write("Entre com o número da conta: ");
        int conta = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        SistemaBanco p = new SistemaBanco(conta, titular);

        Console.Write("Haverá depósito inicial (s/n)? ");
        char validar = Console.ReadKey().KeyChar;

        Console.WriteLine();

        switch (validar) {
            case 's':
                Console.Write("Entre com o valor do depósito inicial: ");
                p.PrimeiroDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.WriteLine($"Dados da conta:\n{p}");
                break;
            case 'n':
                Console.WriteLine($"Dados da conta:\n{p}");
                break;
        }
        Console.WriteLine();
        Console.Write("Entre com um valor para depósito: ");
        p.SegundoDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine($"Dados da conta atualizados:\n{p}");
        Console.WriteLine();
        Console.Write("Entre com um valor para saque: ");
        p.RetirarDinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine($"Dados da conta atualizados:\n{p}");

    }
}