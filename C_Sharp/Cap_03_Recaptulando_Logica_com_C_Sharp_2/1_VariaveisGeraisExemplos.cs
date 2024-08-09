using System;
using System.Globalization;

namespace PrimeiroProjeto //Por questão de boa pratica e organização, é sempre recomendável utilizar as classes dentro de namespace
{
    class Program //Todo cód. fonte que escrevermos, precisa estar dentro de uma classe, que éa unidade basica da programação orientada a objetos, o nome da classe pode ser o mesmo nome do programa
    {
        static void Main(string[] args) //Entry point da aplicação, ponte de entrada de onde aplicação começa, tudo o que está dentro da chave será executado em primeiro lugar
        {
            sbyte x = 100;
            bool Completo = false;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //recomendaçao utilizar o L para sabermos que estamos a usar long
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5f; // é necessário acrescentar o f para reconhecer o float
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Victor Brown"; // Aceita qlq coisa, seja int, float etc...
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;
            double n11 = 10.0 / 8; //Acrescentar o ponto ou casting (double)

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; //Math.Pow faz a potencialização do elemento
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // Math.Sqrt faz o cálculo da raiz quadrada


            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(Completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6.ToString("F2")); //Imprime com duas casas decimais!
            Console.WriteLine(n6.ToString("F2", CultureInfo.InvariantCulture)); //Imprime com o ponto no lugar da vírgula
            Console.WriteLine(nome);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
        }
    }
}