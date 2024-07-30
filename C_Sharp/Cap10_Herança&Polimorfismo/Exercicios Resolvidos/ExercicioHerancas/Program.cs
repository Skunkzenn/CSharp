using ExercicioHerancas;
using System.Globalization;

Console.Write("Enter the number of employees: ");
int numReg = int.Parse(Console.ReadLine());

for (int i = 0; i < numReg; i++)
{
    Console.WriteLine($"Employee #{i + 1} data:");
    Console.Write("Outsourced (y/n)? ");
    char valida = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string nome = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (valida == 'y')
    {
        
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Employee employee = new OutSourceEmployee(nome, hours, valuePerHour, additionalCharge);
        employee.Payment();
        Employee.listEmployees.Add(employee);
    }
    else
    {
        Employee employee = new Employee(nome, hours, valuePerHour);
        employee.Payment();
        Employee.listEmployees.Add(employee);
    }
}

foreach (Employee employee in Employee.listEmployees) {
    Console.WriteLine("PAYMENTS: ");
    Console.WriteLine($"{employee} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}