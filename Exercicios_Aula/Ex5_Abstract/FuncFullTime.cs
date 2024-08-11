using System.Globalization;

namespace Ex5_Abstract
{
    class FuncFullTime : Funcionario
    {
        public double HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }
        public double Duocecimos { get; set; }
        public FuncFullTime() { }
        public FuncFullTime(int id, string name, double salarioBase, double horaTrab, double valorHora, double duocecimos) : base(id, name, salarioBase)
        {
            HorasTrabalhadas = horaTrab;
            ValorHora = valorHora;
            Duocecimos = duocecimos;
        }
        public override double CalcularSalario()
        {
            return SalarioBase += (HorasTrabalhadas * ValorHora) + Duocecimos;
        }

        public override string ToString()
        {
            return base.ToString() + " Horas trabalhadas: " + HorasTrabalhadas + " Valor Hora: " + ValorHora.ToString("F2", CultureInfo.InvariantCulture) + " Duodécimos: " + Duocecimos.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
