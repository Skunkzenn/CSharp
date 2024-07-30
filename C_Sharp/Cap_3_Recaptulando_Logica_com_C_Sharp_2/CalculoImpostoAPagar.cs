using System;
using System.Globalization;

namespace Projetos_CSharp;

internal class CalculoImpostoAPagar
{
    static void Main(string[] args)
    {
        /* Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa. Em seguida, calcule e
        mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo. 
                 1º 0 ate 2000 = isento
                 2º 2000.01 ate 3000 = 8%
                 3º 3000.01 ate 4500 = 18%
                 4º acima de 4500 = 28%
        */

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;
           

            if (salario <= 2000.0) {
                imposto = 0.0;
            } 
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                // - 2000 Isenção e 1000 pertence a taxa de 8% ou seja 2000+1000 calcular salario - 3000 para assim encontrar o valor a aplicar a taxa a quem ganha mais de 3000 
                imposto = (salario - 3000.0) * 0.18 + 1000 * 0.08; 
            }
            else {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine($"Você vai pagar de imposto {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
           
    }
}
