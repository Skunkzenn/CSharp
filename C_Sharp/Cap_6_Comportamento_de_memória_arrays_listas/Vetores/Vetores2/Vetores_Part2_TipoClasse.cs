/* Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos. 
 * Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos. 

   Input: 3
          TV
          900.00
          Fryer
          400.00
          Stove
          800.00

Output: AVERAGE PRICE = 700.00 
*/

using System;
using System.Globalization;

namespace Exercicios_C_.Vetores.Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            //numero de produtos a serem inseridos
            int n = int.Parse(Console.ReadLine());

            //Tipo do vector será do tipo Product, abrindo as [] normalmente para indicar que é um vetor, fazendo o new Product[n] receber o valor de n produtos a serem inseridos;
            //Ao fazer isso, as casinhas no heap estão a valer null, porque null é o valor padrão para tipo referêcia
            //Se quisermos colocar valor nas casas, devemos primeiro instanciar o produto e ai sim instanciar cada um dos objetos
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Ao inserir os dados do produto, agora sim vamos instanciar o mesmo, acrescentando os valores para ele
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {       //vect[i] na posição price
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}