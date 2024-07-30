using System;
using System.Globalization;

namespace aulas_udemy.ClassesMetodosAtributosStatic
{
     class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }
        public double Diagonal()
        {
            double diagonal = Math.Pow(Altura, 2) + Math.Pow(Largura, 2);
            return Math.Sqrt(diagonal);
        }
    }
}
