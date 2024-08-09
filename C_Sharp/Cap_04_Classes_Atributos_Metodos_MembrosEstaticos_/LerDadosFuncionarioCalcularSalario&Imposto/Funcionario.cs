using System.Globalization;
namespace AutoPropriedades_
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return Nome + " $: " + SalarioLiquido();
        }

        public void AumentarSalario(double percentagem)
        {
            SalarioBruto += (SalarioBruto * percentagem / 100);
        }
    }
}