/* Fazer um programa para ler dois números inteiros M e N. Ok
 * Depois ler uma matriz de M linhas por N colunas contendo números inteiros podendo haver repetições. Ok
 * Em seguida, ler um número inteiro X que pertence à matriz. 
 * Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo.
*/

using System;

namespace Matrizes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write this array:");
            string[] dimension = Console.ReadLine().Split(' ');
            int n = int.Parse(dimension[0]); // Número de linhas
            int m = int.Parse(dimension[1]); // Número de colunas

            int[,] mat = new int[n, m]; // Declaração da matriz

            // Preenchendo a matriz com valores do usuário
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Search number: ");
            int seachNum = int.Parse(Console.ReadLine()); // Número a ser procurado na matriz

            // Percorrendo a matriz para encontrar o número procurado
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Verifica se o número atual é igual ao número procurado
                    if (seachNum == mat[i, j])
                    {
                        Console.WriteLine("Position: " + i + ", " + j); // Imprime a posição do número encontrado

                        // Verifica se existe uma coluna à esquerda
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]); // Imprime o valor à esquerda
                        }

                        // Verifica se existe uma linha acima
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]); // Imprime o valor acima
                        }

                        // Verifica se existe uma coluna à direita
                        if (j < m - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]); // Imprime o valor à direita
                        }

                        // Verifica se existe uma linha abaixo
                        if (i < n - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]); // Imprime o valor abaixo
                        }
                    }
                }
            }
        }
    }
}
