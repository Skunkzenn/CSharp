/*
 
Fazer um programa para ler os dados (nome, email e salário)
de funcionários a partir de um arquivo em formato .csv. OK

Em seguida mostrar, em ordem alfabética, o email dos
funcionários cujo salário seja superior a um dado valor
fornecido pelo usuário.


Mostrar também a soma dos salários dos funcionários cujo
nome começa com a letra 'M'.
*/

using Lambda_delegates_linq.Entities;
using System.Globalization;

namespace Lambda_delegates_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string file = Console.ReadLine();

            List<Employee> employee = new List<Employee>();

            using (StreamReader sr = File.OpenText(file))
            {
                if (sr != null)
                {
                    while (!sr.EndOfStream)
                    {
                        string[] partLine = sr.ReadLine().Split(',');
                        string empName = partLine[0];
                        string empEmail = partLine[1];
                        double empSalary = double.Parse(partLine[2], CultureInfo.InvariantCulture);
                        employee.Add(new Employee(empName, empEmail, empSalary));
                    }

                    Console.Write("Enter salary: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine($"Email of people whose salary is more than {value}:");

                    var supSalary = employee.Where(x => x.Salary > value).OrderBy(p => p.Email).Select(p => p.Email);
                    foreach (string email in supSalary)
                    {
                        Console.WriteLine(email);
                    }

                    var sumSalary = employee.Where(x => x.Name[0] == 'M').Sum(p => p.Salary);
                    Console.Write($"Sum of salary of people whose name starts with 'M': {sumSalary.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
