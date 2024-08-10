using Interfaces_List.Services;
using Interfaces_List.Entities;
using System.Globalization;

namespace Interfaces_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
