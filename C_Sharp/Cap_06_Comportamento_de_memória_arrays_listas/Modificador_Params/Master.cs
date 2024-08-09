using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Master
    {
        static void Main(string[] args) { 
                                    //Uma forma compacta de utilizarmos o vetor já com os dados dentro
                                    //Ficaria muito ruim, desconfortável, ter de utilizar essa estrutura, por isso, usamos o params
        int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
        Console.WriteLine(result);

            //Basta agora declarar com quantas entradas quisermos
            int result2 = Calculator.Sum(2, 3);
            int result3 = Calculator.Sum(2, 3, 5);
        }
    }
}
