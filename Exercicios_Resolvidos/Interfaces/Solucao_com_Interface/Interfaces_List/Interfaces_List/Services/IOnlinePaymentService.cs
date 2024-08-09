namespace Interfaces_List.Services
{
    interface IOnlinePaymentService
    {
        //Apenas declarar as propriedades obrigatórias
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
