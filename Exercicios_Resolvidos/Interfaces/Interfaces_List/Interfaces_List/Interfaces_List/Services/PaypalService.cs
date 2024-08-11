namespace Interfaces_List.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double SimpleTax = 0.01;
        private const double Tax = 0.02;


        public double Interest(double amount, int months)
        {
            return amount * SimpleTax * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * Tax;
        }
    }
}
