using Classes;
using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace AutoPropriedades_
{
    class Program
    {
        /*  Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários. */
        static void Main(string[] args)
        {   //Chamar a classe e criar as variáveis
            SalarioColaborador x, y;
            //Criar a instânciação
            x = new SalarioColaborador();
            y = new SalarioColaborador();

            Console.WriteLine("Dados do primeiro funcionário:");
            x.nome = Console.ReadLine();
            x.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nome: {x.nome}\nSalario: {(x.salario).ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Dados do segundo funcionário:");
            y.nome = Console.ReadLine();
            y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nome: {y.nome}\nSalario: {y.salario.ToString("F2", CultureInfo.InvariantCulture)}");

            double mediaSalarial = (x.salario + y.salario) / 2;

            Console.WriteLine($"Salário médio: {mediaSalarial.ToString("F2")}");

        }
    }
}