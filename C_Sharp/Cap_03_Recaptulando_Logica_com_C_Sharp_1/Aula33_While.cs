using System;
using System.Globalization;

namespace CursoUdemy
{
    internal class Aula33_While
    {
        static void Main(string[] args)
        {
            // Aula 32 - Estrutras de Repetição
            
            Console.WriteLine("Digite um número");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Se for verdadeiro, executa e volta
            //Se for falso, sai fora
            while (numero > 0)
            {
            double resultado = 0;
            resultado = Math.Sqrt(numero);
            Console.WriteLine(resultado.ToString("F3"));
            Console.WriteLine("Digite outro número");

            //Aqui precisa-se de ter atenção pois como a variavel numero é a responsavel pelo ciclo, usamos ela para validar sempre o loop, até o contrário;
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número Negativo");

            }
            
        }
    }
}
