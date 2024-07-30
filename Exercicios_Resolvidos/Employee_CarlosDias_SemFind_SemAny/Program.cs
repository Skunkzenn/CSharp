using System.Globalization;
using System.Runtime.Intrinsics.X86;
using ListEmployee;

class Exercicios
{
    static void Main(string[] args)
    {
        Console.Write("How many employees will be registered? ");
        int registros = int.Parse(Console.ReadLine());

        List<Employee> listEmployee = new List<Employee>();


        for (int i = 1; i <= registros; i++)
        {
            Console.WriteLine($"Emplyoee #{i}:");
            Console.Write("Id: ");
            int clientId = int.Parse(Console.ReadLine());

            bool isOnList = false;
            foreach (Employee emp1 in listEmployee)
            {
                int aux = emp1.getIdEmployee();
                if (aux == clientId) isOnList = true;
            }
            if (!isOnList) {
                Console.Write("Name: ");
                string clientName = Console.ReadLine();
                Console.Write("Salary: ");
                double clientSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // Cria uma nova instância da classe `Employee` com todos os dados do novo empregado
                Employee employee = new Employee(clientId, clientName, clientSalary);

                // Adiciona o novo empregado à lista
                listEmployee.Add(employee);
            }
            else
            {
                Console.WriteLine("Client ID already exists.");
            }
        }

        Console.WriteLine("Enter the employee id that will have salary increase: ");
        int localizeId = int.Parse(Console.ReadLine());

        bool exist = false;
        foreach (Employee emp1 in listEmployee)
        {
            int aux = emp1.getIdEmployee();
            if (aux == localizeId)
            {
                Console.Write("Enter the percentage: ");
                double percetage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp1.increaseSalary(percetage);
                exist = true;
            }
        }
        if (!exist) { 
            Console.WriteLine("This id does not exist!"); 
        }

        Console.WriteLine();
        Console.WriteLine("Updated list of employees:");

        foreach (Employee obj in listEmployee)
        {
            Console.WriteLine(obj);
        }
    }
}