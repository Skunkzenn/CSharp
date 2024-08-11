using Course;
using System.Globalization;

namespace Exercicios_Em_Aula;

class Master
{
    static void Main(string[] args)
    {
        Angulo angulo = new Angulo();

        angulo.Grau = 180.00;
        angulo.Radiano = 90.00;

        Console.WriteLine(angulo);
    }
}
