using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando uma matriz bidimensional de inteiros
            Console.Write("Write this length this matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] vetor = new int[n, n]; // vetor de inteiros

            //Preencher a matriz
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    vetor[i, j] = int.Parse(valores[j]);
                }
            }

            // Imprimir a matriz
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i, i]);
            }

            // Contar os valores negativos
            int count = 0;
            foreach (int valor in vetor)
            {
                if (valor < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
