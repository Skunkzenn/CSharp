using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pede para o utilizador inserir a ordem da matriz
            int n = int.Parse(Console.ReadLine());

            //Instanciar uma matriz n por n, ou seja, com n linhas e n colunas
                         //recebe um int porque o tipo da matriz é de inteiros   
            int[,] mat = new int[n, n];

            //Esse for do 'i' tem o intuito de percorrer as linhas
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                //Esse for é responsável por correr as colunas, que vai se executar, para cada uma das linhas
                for (int j = 0; j < n; j++)
                {   //Como values é um vetor de strings, vamos ter que percorrer o vetor e converter cada um deles (int.Parse...)
                    //Recebe int.Parse do values posição 'j', que inicia como 0!! 
                    mat[i, j] = int.Parse(values[j]); //No caso será o primeiro número inserido pelo utilizador, ou seja, 5 -3 10, a posição 0 do 'j' será 5
                    //Joga-se o resultado no mat[i, j] ou seja, linha i vale 0 e coluna vale 0, mas ao executar com os valores, o valor de 'j' irá ser trocado para o primeiro valor inserido
                    //Ficando assim Linha 0 e coluna 0 com valor de 5 atribuído na matriz
                }
                //Na segunda instância vamos continuar a ter i = 0 mas j = 1 
                //Vai pegar a posição 1 do 'j' que é -3 e vai guardar na matriz 'mat', convertendo a string em int e assim ficando o valor de mat[0, 1] = -3!!!
                //Ao fim de ler a quantidade de números inseridos, o for do 'j' vai ser finalizado e assim vamos correr o segundo for do 'i' que irá definir os valores da segunda linha
            }

            Console.WriteLine("Main diagonal:");
            //Como para exibir o Main diagonal nós precisamos definir o valor da linha e da coluna, mas podemos ter noção de que, o mesmo valor da linha é o da coluna, ou seja 0,0...1,1...2,2...
            for (int i = 0; i < n; i++)
            {   //Imprimir o mat[i, i] ou seja passa o mesmo valor para ambos, linha e coluna
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            //variável responsável por contar os elementos negativos
            int count = 0;
            //Para identificar os nº negativos, fazer novamente 2 for, para um percorrer a linha e outro percorrer as colunas;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {   //se o elemento da matriz, na linha i coluna j for negativo.... vamos considerar ele na contagem, ou seja, count++
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }
    }
}