using AutoPropriedades_;

using System.Globalization;

namespace Classes.MembrosEstaticos.Exercicios.CotacaoDollar.Calculadora.Versao3
{
    class Master
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2",
            CultureInfo.InvariantCulture));
        }
    }
}