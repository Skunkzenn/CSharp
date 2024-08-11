using Course;
using System.Globalization;

namespace Exercicios_Em_Aula.ExerciciosAulaPOO.Triangulo;

class Master
{
    static void Main(string[] args)
    {
        Triangulo triangulo = new Triangulo();

        Console.Write("Lado A: ");
        double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Lado B: ");
        double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Lado C: ");
        double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        triangulo.Dimensoes(ladoA, ladoB, ladoC);

        Console.WriteLine($"O triangulo é: {triangulo.Tipo()}");
    }
}
