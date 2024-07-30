using AutoPropriedades_;
using System;
using System.Globalization;

namespace Testes_CSharp;

class Master
{
    static void Main(string[] args){

        Aluno aluno = new Aluno();
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Nome do aluno: " + aluno.Nome);
        Console.WriteLine("Digite as três notas do aluno:");
        aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(aluno);

        //Opção com ternário
        //Console.WriteLine(aluno.ResultadoFinal() ? "APROVADO" : "REPROVADO");

        if (aluno.ResultadoFinal()){
            Console.WriteLine("APROVADO");
        }
        
        else { 
            Console.WriteLine("REPROVADO");
            double pontosEmFalta = aluno.PontosEmFalta();
            Console.WriteLine($"PONTOS EM FALTA: {pontosEmFalta.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
