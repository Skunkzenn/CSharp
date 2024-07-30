using System;
using System.Globalization;

namespace Employee_RegisterAndIncreaseSalary;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many employees will be registered? ");
        int numOfReg = int.Parse(Console.ReadLine());

        List<Employee> listEmployees = new List<Employee>();

        for (int i = 0; i < numOfReg; i++)
        {
            Console.WriteLine($"Employee #{i + 1}");
            Console.Write("Id: "); int id = int.Parse(Console.ReadLine());
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Salary: "); double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Primeiro criar uma uma nova instância da classe 'Employee' para receber os dados no novo empregado
            //!!!!!!!! SUPER IMPORTANTE !!!!!!!
            Employee employee = new Employee(id, name, salary);
            listEmployees.Add(employee);
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        int idEmployee = int.Parse(Console.ReadLine());

        //Criar uma instância da classe 'Employee' passando como parâmetro uma var auxiliar 'emp' para assim ela ser usada como motor de busca dentro da listEmployees.
        Employee emp = listEmployees.Find(e => e.Id == idEmployee);

        //Utilizar 'emp' como entrada, pois assim estaramos a passar a condição dele conjugando com a do if mais abaixo
        if (emp != null)
        {
            Console.Write("Enter the percentage: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.increaseSalary(aumento);
        }
        else
        {
            Console.Write("This id does not exist!");
        }

        foreach (Employee e in listEmployees)
        {
            Console.WriteLine("Update list of employees: ");
            Console.WriteLine(e);
        }
    }
}