using Exercicios_C_;
using System;
using System.Globalization;

namespace Course;

class Program
{
    static void Main(string[] args)
    {

        ContaBancaria conta;

        Console.Write("Entre com o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char validar = Console.ReadKey().KeyChar;

        if (validar == 's' || validar == 'S'){
            Console.WriteLine("Entre o valor de deposito inicial: ");
            //Criar var temporária para armazenar o valor e não prejudicar o cod
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Dentro do if é qeu chamamos a instânciação
            conta = new ContaBancaria(numero, titular, depositoInicial);
        }
        else { conta = new ContaBancaria(numero, titular); }

        Console.WriteLine();
        Console.WriteLine("Dados da Conta:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre com o valor de deposito: ");
        double quantia = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
        conta.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre com o valor de saque: ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);

    }
}