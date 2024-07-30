namespace Ex4_Interfaces
{
    interface IPagamento
    {
        double CalcularPagamento(int qnt, double valorUn);

        double ProcessarPagamento(double desconto);
    }
}
