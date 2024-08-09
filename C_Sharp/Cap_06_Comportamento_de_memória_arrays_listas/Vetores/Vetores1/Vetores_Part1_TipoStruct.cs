/*
• Em programação, "vetor" é o nome dado a arranjos unidimensionais
• Arranjo é uma estrutura de dados:
• Homogênea(dados do mesmo tipo)
• Ordenada(elementos acessados por meio de posições)
• Alocada de uma vez só, em um bloco contíguo de memória
• Vantagens:
• Acesso imediato aos elementos pela sua posição
• Desvantagens:
• Tamanho fixo
• Dificuldade para se realizar inserções e deleções. 

1)Fazer um programa para ler um número inteiro N e a altura de N pessoas.
Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.
Entrada: 3
         1.72
         1.56
         1.80
Saída: AVERAGE HEIGHT = 1.69
*/

using System;
using System.Globalization;

namespace Course
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                //Para criar um vetor, contendo numeros double, o [] indica que é um vetor;
                                //entre [] está o tamanho do vetor, ou seja, n elementos
                double[] vect = new double[n];
                //Vai executar a posicao, 0, 1, 2 e no 3 pula fora
                for (int i = 0; i < n; i++)
                {   
                    //Cada valor do indice será percorrido, para cada posição, eu vou fazer a leitura de um numero, armazenando o numero na caixinha do vetor;
                    //Para cada posição lida, ele vai armazenar o seu valor inserido naquela posição
                    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                double sum = 0.0;
                for (int i = 0; i < n; i++)
                {
                    sum += vect[i];
                }
                double avg = sum / n;
                Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
