using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp
{
    internal class Intervalo_ValorPertence
    {
        static void Main(string[] args)
        {

            /* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
               seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
               nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. */

            double conferir = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (conferir < 0) { Console.WriteLine("Error, número negativo!"); }
            else if (conferir <= 25) Console.WriteLine("Intervalo: [0,25]");
            else if (conferir <= 50) Console.WriteLine("Intervalo: (25, 50]");
            else if (conferir <= 75) Console.WriteLine("Invervalo: (50, 75]");
            else if (conferir <= 100) Console.WriteLine("Intervalo: (75, 100]");
            else Console.WriteLine("Número não encontrado, tente novamente");

        }
    }
}
