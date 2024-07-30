using System;
using Course.Entities;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Dados inseridos pelo utilizador
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //Realiza primeira verificação, para que não seja inserida uma data de check-in menor que a de entrada
            if (checkOut <= checkIn) {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else {
                //Assume a reserva com os parâmetros que deram entrada, com nova instância a ser criada de 'Reservation'
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                //Entra com a nova data para reserva
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                //Realiza verificação para que não seja aceitável registrar datas anteriores a data atual
                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now) {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }//Realiza verificação para que não seja aceitável datas de checkin menores ou iguais a data de saída
                else if (checkOut <= checkIn) {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
