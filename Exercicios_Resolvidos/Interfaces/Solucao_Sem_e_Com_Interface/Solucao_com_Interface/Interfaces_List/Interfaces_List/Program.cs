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

            //Instanciar o contracto conforme os parâmetros do construtor
            Contract contract = new Contract(number, date, value);

            //Instanciar o contracto de servico com a modalidade do serviço
            ContractService contractService = new ContractService(new PaypalService());

            //Processo do contracto com base na função
            contractService.ProcessContract(contract, months);

            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
