using System;
using System.Globalization;

namespace Projetos_CSharp
{
    internal class CalculoImpostoAPagar2
    {
        static void Main(string[] args)
        {
            /* 8) Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. 
             * Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo. 
             * Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00
             * pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.
             * No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. 
             * O valor deve ser impresso com duas casas decimais.
             * 
             * de 0.00€ a 2000.00€ Isento
             * de 2000.01€ ate 3000.00€ 8%
             * de 3000.01€ ate 4500.00€ 18%
             * acima de 4500.00€ 28%
             * 
            */

            
            Console.WriteLine("Digite o valor do salário: xxxx.xx");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = 0.0;

            if (salario < 0) Console.WriteLine("Erro, salário não pode ser negativo.");
            else if (salario <= 2000.00) Console.WriteLine("Isento");
            else if (salario <= 3000.00) desconto = (salario - 2000.00) * 0.08;      
            else if (salario <= 4500.00) desconto = (salario - 3000) * 0.18 + (1000 * 0.08);
            else {  desconto = (salario - 4500) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
            }

            Console.WriteLine($"Valor do IRS: {desconto.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}
