using System;
using Employe;
using System.Collections.Generic;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Emplyoee #{i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            
            if(employees.Find(x => x.Id == searchId) == null)
            {
                Console.Write("This id does not exist!");
                return;
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double searchPercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Find(x => x.Id == searchId).IncreaseSalary(searchPercentage);
            }

            Console.WriteLine("Updated list of employees:");
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

        }
    }
}