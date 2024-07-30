using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    class Aula34_FOR
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int qntNum = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= qntNum; i++)
            {   //Imprime a posição do i, variavel que verifica quantas repetições teremos, ter atenção a lógica
                Console.WriteLine($"Valor: #{i}:");
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
                //OU soma += valor;
            }

            Console.WriteLine($"Soma: {soma}");
        }
    }
}
}
