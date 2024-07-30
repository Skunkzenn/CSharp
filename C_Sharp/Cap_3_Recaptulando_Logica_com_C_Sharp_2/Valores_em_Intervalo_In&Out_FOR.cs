using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp
{
    internal class Valores_em_Intervalo_In_Out_FOR
    {

        static void Main(string[] args)
        {
            /* Leia um valor inteiro N.
             * Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
             Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
             essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). */

            Console.Write("Digite um número inteiro: ");
            int numN = int.Parse(Console.ReadLine());
            int somaIn = 0;
            int somaOut = 0;

            for (int i = 1; i <= numN; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {   //Ter atenção a lógica, pois como o valor de somaIn antes de iniciar será 0, toda vez que for confirmado que o
                    //Inteiro inserido confirma com os requisitos do If, sera agregado um valor ao somaIn.
                    somaIn++;
                }
                else
                {   //O mesmo vale para o somaOut, ter atenção a lógica
                    somaOut++;
                }
            }
            Console.WriteLine("In" + somaIn);
            Console.WriteLine("Out" + somaOut);
        }
    }
}
