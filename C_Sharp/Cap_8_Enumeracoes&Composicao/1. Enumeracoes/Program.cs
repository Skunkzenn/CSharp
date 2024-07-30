/* Checklist
    � Defini��o / discuss�o
    � Exemplo: estados de um pedido
    � Convers�o de string para enum
    � Representa��o UML

Enumera��es
    � � um tipo especial que serve para especificar de forma literal um conjunto
    de constantes relacionadas
    � Palavra chave em C#: enum
    � Nota: enum � um tipo valor
    � Vantagem: melhor sem�ntica, c�digo mais leg�vel e auxiliado pelo compilador

� Refer�ncia: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum

Exemplo
Ciclo de vida de um pedido. 
 
 
 
 */

using System;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);

            //Para o tipo original: use casting


            OrderStatus os1 = (OrderStatus)2;
            int n1 = (int)OrderStatus.Processing;
            string - enum:
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
    }
}