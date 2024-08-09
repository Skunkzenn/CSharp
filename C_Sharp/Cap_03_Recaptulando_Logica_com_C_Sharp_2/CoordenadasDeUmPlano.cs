using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp
{
    internal class CoordenadasDeUmPlano
    {
        static void Main(string[] args)
        {

            /* Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
               de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
               ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
               Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação. */
            
            Console.WriteLine("Digite os eixos X e Y: x y");
            string[] vetores = Console.ReadLine().Split(' ');
            double eixoX = double.Parse(vetores[0], CultureInfo.InvariantCulture);
            double eixoY = double.Parse(vetores[1], CultureInfo.InvariantCulture);

            if (eixoX > 0 && eixoY > 0) Console.WriteLine("Quadrante 1");
            else if (eixoX < 0 && eixoY > 0) Console.WriteLine("Quadrante 2");
            else if (eixoX < 0 && eixoY < 0) Console.WriteLine("Quadrante 3");
            else if (eixoX > 0 && eixoY < 0) Console.WriteLine("Quadrante 4");
            else if (eixoY == 0 && eixoX == 0) Console.WriteLine("Origem");
            else Console.WriteLine("Error de leitura, tente novamente");
        }
    }
}
