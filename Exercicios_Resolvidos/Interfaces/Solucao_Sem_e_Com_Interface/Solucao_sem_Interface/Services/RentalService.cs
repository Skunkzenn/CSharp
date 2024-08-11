using System;
using Course.Entities;

namespace Course.Services {
    class RentalService {

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0) {
                //Math.Ceiling para arredondar para cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //tax serve para armazenar o valor correspondente a taxa do brasil, baseado no valor base do pagamento
            double tax = _brazilTaxService.Tax(basicPayment);

            //declara o aluguel passando os parâmetros necessarios, lembrar que invoice é atributo da class CarRental
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
