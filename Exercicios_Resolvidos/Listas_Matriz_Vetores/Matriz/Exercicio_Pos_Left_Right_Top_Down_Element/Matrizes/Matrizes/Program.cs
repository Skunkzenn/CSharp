using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o numero de linhas e colunas. A seguir os valores da matriz. Split(' ')");
            //Utilizador insere as linhas e colunas da matriz, definidas por m e n
            string[] dimensoes = Console.ReadLine().Split(' ');
            int mLinhas = int.Parse(dimensoes[0]);
            int nColunas = int.Parse(dimensoes[1]);

            //Instanciar a matriz, com mLinhas e nColunas
            int[,] mat = new int[mLinhas, nColunas];

            //1º for corre a primeira dimensão da matriz, ou seja, as LINHAS!!
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                //2º for corre a segunda dimensão da matriz, ou seja, as COLUNAS!!
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    //valores é um vetor de strings, necessário converter
                    mat[i, j] = int.Parse(valores[j]); // j inicia como 0!! ou seja, primeirõ ciclo do for será LINHA 0, COLUNA 0 = [0, 0], [0,1 ]...[0, 5]....[0,N numeros]
                                                       // Dessa forma ao finalizar o primeiro ciclo do for, a linha 0 coluna 0 toma o valor do primeiro numero inserido
                }
            }

            int encontra = int.Parse(Console.ReadLine());

            //bool encontrado = false; //var para rastrear se valor foi encontrado

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == encontra)
                    { // Verifica se o número na posição atual da matriz é igual ao número que você está procurando
                        Console.Write($"Numero encontrado na posição [{i}, {j}]");
                        Console.WriteLine();
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: [{i}, {j - 1}] {mat[i, j - 1]}");
                        }
                        if (j < mat.GetLength(1) - 1)
                        {
                            Console.WriteLine($"Right: [{i}, {j + 1}] {mat[i, j + 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Top: [{i - 1}, {j}] {mat[i - 1, j]}");
                        }
                        if (i < mat.GetLength(0) - 1)
                        {
                            Console.WriteLine($"Down: [{i + 1}, {j}] {mat[i + 1, j]}");
                        }
                        // break; // sai do loop assim que encontrar o número, evitando percorrer novamente o for pois os numeros já foram encontrados
                    }

                    /* if (encontrado)
                    {
                        break; //sai do loop externo, se o numero for encontrado, evitando percorrer todas as linhas novamente, pois já foi encontrado
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Nenhum resultado encontrado.");
                    } */
                }


            }
        }
    }
}
