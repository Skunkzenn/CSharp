using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Abstract
{
    class FuncPartTime : Funcionario
    {
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public FuncPartTime() { }
        public FuncPartTime(int id, string name, double salarioBase, int horaTrab, double valorHora) : base(id, name, salarioBase)
        {
            HorasTrabalhadas = horaTrab;
            ValorHora = valorHora;
        }
        public override double CalcularSalario()
        {
            return SalarioBase += HorasTrabalhadas * ValorHora;
        }
        public override string ToString()
        {
            return base.ToString() + " Horas trabalhadas: " + HorasTrabalhadas + " Valor Hora: " + ValorHora.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
