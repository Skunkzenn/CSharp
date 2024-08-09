using System;
using System.Globalization;

namespace Projetos_CSharp
{
    internal class CalculoArea_UsingMathPow
    {
        static void Main(string[] args)
        {
    /* 
    Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.
    Em seguida, calcule e mostre:

    a) a área do triângulo retângulo que tem A por base e C por altura.
        Área = (Base * Altura) / 2 
    b) a área do círculo de raio C. (pi = 3.14159)
    c) a área do trapézio que tem A e B por bases e C por altura.
    d) a área do quadrado que tem lado B.
    e) a área do retângulo que tem lados A e B. 
    */


            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double areaTrianguloRet, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            areaTrianguloRet = (a * c) / 2;
            areaCirculo = pi * Math.Pow(c, 2);
            areaTrapezio = ((a + b) * c) / 2;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("Triangulo: " + areaTrianguloRet.ToString("F3"));
            Console.WriteLine("Circulo: " + areaCirculo.ToString("F3"));
            Console.WriteLine("Trapézio: " + areaTrapezio.ToString("F3"));
            Console.WriteLine("Quadrado: " + areaQuadrado.ToString("F3"));
            Console.WriteLine("Retangulo: " + areaRetangulo.ToString("F3"));

        }
    }
}
