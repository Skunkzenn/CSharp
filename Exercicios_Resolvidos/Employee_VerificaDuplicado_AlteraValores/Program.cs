using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercicios_Teste.Exercicio_Employee_VerificaDuplicado_AlteraValores;

/* 
 
    Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
    N funcionários. Não deve haver repetição de id.
    Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
    Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
    mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
    conforme exemplos.
    Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
    ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
    aumento por porcentagem dada.
 
 */

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


            // Verifica se o ID já existe na lista
            if (listEmployee.Any(employee => employee.Id == clientId))
            {
                Console.WriteLine("Client ID already exists.");
            }
            else
            {
                Console.Write("Name: ");
                string clientName = Console.ReadLine();
                Console.Write("Salary: ");
                double clientSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // Cria uma nova instância da classe `Employee` com todos os dados do novo empregado
                Employee employee = new Employee(clientId, clientName, clientSalary);

                // Adiciona o novo empregado à lista
                listEmployee.Add(employee);
            }
        }

        Console.WriteLine("Enter the employee id that will have salary increase: ");
        int localizeId = int.Parse(Console.ReadLine());

        Employee emp = listEmployee.Find(x => x.Id == localizeId);
        if (emp != null)
        {
            Console.Write("Enter the percentage: ");
            double percetage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.increaseSalary(percetage);
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }

        Console.WriteLine();
        Console.WriteLine("Updated list of employees:");

        foreach (Employee obj in listEmployee)
        {
            Console.WriteLine(emp);
        }
    }
}