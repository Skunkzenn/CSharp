using System.Globalization;

namespace Ex4_Interfaces
{
    class Venda : IPagamento
    {
        public double ValorTotal { get; set; }
        public string Cliente { get; set; }


        public Venda() { }

        public Venda(double valorTotal, string cliente) {
            ValorTotal = valorTotal;
            Cliente = cliente;
        }

        public double CalcularPagamento(int qnt, double valorUn)
        {
            return ValorTotal = qnt * valorUn;
        }

        public double ProcessarPagamento(double iva)
        {
            double desconto = 0.10 * ValorTotal;
            return ValorTotal -= desconto + (ValorTotal * iva);
        }

        public override string ToString()
        {
            return $"Nome Cliente: {Cliente}, Valor Total: {ValorTotal.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
