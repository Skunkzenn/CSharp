using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. */

namespace Projetos_CSharp
{
    internal class HoraInicial_HoraFinal
    {
        static void Main(string[] args)
        {
            string[] vetores = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(vetores[0]);
            int horaFim = int.Parse(vetores[1]);
            int resultado;

            if(horaInicio < horaFim)
            resultado = horaFim - horaInicio;

            //Entender bem essa lógica
            else resultado = 24 - horaFim + horaInicio;

        }
    }
}
