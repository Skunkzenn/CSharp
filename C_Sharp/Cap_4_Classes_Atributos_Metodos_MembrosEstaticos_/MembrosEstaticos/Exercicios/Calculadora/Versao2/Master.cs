using AutoPropriedades_;

using System.Globalization;

namespace Classes.MembrosEstaticos.Exercicios.CotacaoDollar.Calculadora.Versao2
{
    class Master
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}