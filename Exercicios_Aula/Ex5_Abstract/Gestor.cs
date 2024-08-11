using System.Globalization;

namespace Ex5_Abstract
{
    class Gestor : Funcionario
    {

        public double Bonus { get; set; }
        public Gestor() { }
        public Gestor(int id, string name, double salarioBase, double bonus):base(id, name, salarioBase) { 
            Bonus = bonus;
        }
        public override double CalcularSalario()
        {
            return SalarioBase += Bonus;
        }
        public override string ToString()
        {
            return base.ToString() + " Bonus: " + Bonus.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
