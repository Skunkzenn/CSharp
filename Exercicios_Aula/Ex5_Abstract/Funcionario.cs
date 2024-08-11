using System.Globalization;

namespace Ex5_Abstract
{
    abstract class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario() { }
        public Funcionario(int id, string name, double salarioBase)
        {
            Id = id;
            Name = name;
            SalarioBase = salarioBase;
        }

        public abstract double CalcularSalario(); // Método abstrato sem implementação

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Name}, Salario Base: {SalarioBase.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
