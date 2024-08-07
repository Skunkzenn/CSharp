/* 

Fazer um programa para ler os dados de uma conta bancária e depois realizar um saque nesta conta bancária, mostrando o novo saldo. 
Um saque não pode ocorrer ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de saque da conta. 
Implemente a conta bancária conforme projeto abaixo: 

Account
- number: Integer
- holder: String
- balance: Double
- withdrawLimit: Double
--------------------------------
+deposit(amount: Double): void
+withdraw(amount: Double): void
 
 */

using Exercicio_Excecoes.Entities;
using Exercicio_Excecoes.Entities.Exceptions;
using System.Globalization;


namespace Exercicio_Excecoes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter account data:");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        string holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Withdraw limit: ");
        double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Account account = new Account(number, holder, balance, withdrawLimit);
        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        try
        {
            account.Withdraw(withdraw);
            Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }        

        catch (DomainException ex)
        {
            Console.WriteLine("Withdraw error: " + ex.Message);
        }
    }
}