using System;

namespace Course.Entities {
    class Reservation {

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public double Duration() {
            //TimeSpan conta o tempo entre datas
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            //Resultado converte-se em dias totais
            return (int)duration.TotalDays;
        }

        //Função que faz o update da data, passando 2 parâmetros de entrada
        public void UpdateDates(DateTime checkIn, DateTime checkOut) {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
