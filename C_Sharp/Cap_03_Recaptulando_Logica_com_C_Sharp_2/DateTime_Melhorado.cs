using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp
{
    internal class DateTime_Melhorado
    {
        static void Main(string[] args)
        {
            /* Programa que calcula o tempo entre x datas utilizando as funções DateTime, TimeSpan e TotalHours */

            Console.WriteLine("Informe a Data e hora de inicio (dd/MM/yyyy HH:mm)");

            //Utilizar o DateTime para representar as datas e horas que vão ser inseridas
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null); //

            Console.WriteLine("Informe a Data e hora de fim (dd/MM/ yyyy HH:mm)");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

            //O TimeSpan serve para calcular a diferença entre essa duas datas, em termos de segundos, minutos, horas etc...
            TimeSpan duracao = fim - inicio;

            Console.WriteLine($"Hora de inicio: {inicio}");
            Console.WriteLine($"Hora de fim: {fim}");
            //Quando você calcula a diferença entre duas datas e horas usando TimeSpan, o TotalHours fornece a duração total em horas, incluindo qualquer parte fracionada, se houver.
            Console.WriteLine($"Total de horas: {duracao.TotalHours}"); 
        }
    }
}
