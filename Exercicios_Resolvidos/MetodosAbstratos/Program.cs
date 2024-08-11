using MetodosAbstratos.Entities;
using System.Globalization;

namespace MetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicPerson(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new JuridicPerson(name, anualIncome, numberOfEmployees));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("TAX PAID:");
            foreach (Person person in list)
            {
                Console.WriteLine(person.Name + ": $ " + person.TotalTax().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();

            double sum = 0.0;
            foreach (Person person in list)
            {
                sum += person.TotalTax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
