using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp;

internal class NegativoOuPositivo2
{
    static void Main(string[] args)
    {
        // FICHA 2 - EXERCICIOS CONDICIONAIS EM C#

        // 1) Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. 
        // Neste exercicio fiz de outra maneira utilizando uma pergunta diretamente, sem precisar de if e else
        
        int inteiro = int.Parse(Console.ReadLine());
        int inteiro2 = int.Parse(Console.ReadLine());

        if (inteiro < 0) {
            Console.WriteLine("Negativo");
        }
        else{
            Console.WriteLine("Positivo");
        }

        //Desta forma, ao utilizar a interrogação, podemos validar as duas alternativas sem precisar de if ou else, somente uma outra forma de fazer
        Console.WriteLine(inteiro2 < 0 || inteiro2 == 0 ? "Negativo" : "Positivo");
        
    }
}
