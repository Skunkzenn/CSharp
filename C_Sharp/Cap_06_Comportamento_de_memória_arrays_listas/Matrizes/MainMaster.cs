using System;

namespace Matrizes;

class Matriz
{
    static void Main(string[] args)
    {
        //declarar primeiro o tipo de dados da matriz
        //[,] -> Define que é uma matriz com linhas e colunas
                                  //Tamanho da Matriz    
        double[,] mat = new double[2, 3];

        Console.WriteLine(mat.Length); //Imprime quantos elementos a matriz  tem no total
        Console.WriteLine(mat.Rank); //Imprime quanto é a primeira dimensao da matriz, a quantidade de linhas
        Console.WriteLine(mat.GetLength(0)); //Imprime o tamanho da primeira dimensão da matriz, que tem tamanho 2
        Console.WriteLine(mat.GetLength(1)); //Imprime o tamanho da segunda dimensão da matriz, que tem tamanho 3
    }
}