using Interfaces_List.Entities;

namespace Interfaces_List.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;


        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            // Valor base devido ao valor ser dividido pela quantidade de meses
            double baseValue = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                //Adiciona os meses de acordo com sua quantidade, com base na data inicial do contracto
                DateTime dateInstallment = contract.Date.AddMonths(i);

                double amountStart = baseValue + _onlinePaymentService.Interest(baseValue, i);
                double amountFinish = amountStart + _onlinePaymentService.PaymentFee(amountStart);

                contract.AddInstalment(new Installment(dateInstallment, amountFinish));
            }
        }
    }
}
