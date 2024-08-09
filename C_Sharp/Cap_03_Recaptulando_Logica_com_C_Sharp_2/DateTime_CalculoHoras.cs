using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_CSharp;

internal class DateTime_CalculoHoras
{
    static void Main(string[] args)
    {
        //Utilizando Date-Time

        Console.WriteLine("Digite a data e hora de início dd/MM/yyyy HH:mm");
        // é necessário fornecer um valor null como o terceiro argumento para indicar que nenhum
        // provedor de formato específico deve ser usado
        DateTime horaInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null); 

        Console.WriteLine("Digite a data e hora de fim dd/MM/yyyy HH:mm");
        DateTime horaFinal = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

        TimeSpan resultado;

        if (horaFinal > horaInicio) resultado = horaFinal - horaInicio;
        else resultado = horaInicio - horaFinal;

        Console.WriteLine($"Inicio no dia: {horaInicio}, terminando no dia: {horaFinal}, com um total de {resultado.ToString()}");
    }
}
