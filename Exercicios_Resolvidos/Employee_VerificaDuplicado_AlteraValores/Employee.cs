using System.Globalization;

namespace Exercicios_Teste.Exercicio_Employee_VerificaDuplicado_AlteraValores
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary += percentage * Salary / 100.0;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }

}
