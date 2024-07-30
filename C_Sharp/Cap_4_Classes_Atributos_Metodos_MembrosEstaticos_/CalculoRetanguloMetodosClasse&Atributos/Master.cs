using System;
using System.Globalization;
using aulas_udemy.ClassesMetodosAtributosStatic;

namespace aulas_udemy.ClassesMetodosAtributosStatic;

internal class Master
{
    static void Main(string[] args)
    {
        Retangulo ret = new Retangulo();
        Console.WriteLine("Entre com a largura e altura do retângulo:");
        ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.WriteLine($"Área: " + ret.Area());
        Console.WriteLine($"Perimetro: " + ret.Perimetro());
        Console.WriteLine($"Perimetro: " + ret.Diagonal());
    }
}
