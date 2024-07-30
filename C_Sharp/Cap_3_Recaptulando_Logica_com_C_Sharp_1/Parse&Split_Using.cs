using System;
using System.Globalization;

namespace Curso_C__Udemy
{
    class Program_3
    {
        static void Main(string[] args)
        {

            // AULA 22

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //string s = Console.ReadLine(); //Podemos utilizar assim ou diretamente, como feito abaixo
            string[] recorte = Console.ReadLine().Split(' '); //Faz o recorte da string s com o espaço em branco, para poder armazenar separadamente os nomes em vetores
            string a = recorte[0];
            string b = recorte[1];
            string c = recorte[2];

            Console.WriteLine("Você escreveu: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


            //AULA 23

            int n1 = int.Parse(Console.ReadLine()); //Converte a string escrita pelo readline em um inteiro
            char ch = char.Parse(Console.ReadLine()); //Converte a string em char
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Converte a string em double

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); //Ter em atenção se estamos a utilizar ',' ou '.'
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
