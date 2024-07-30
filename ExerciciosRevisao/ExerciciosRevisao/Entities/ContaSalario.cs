using System.Globalization;

namespace ExerciciosRevisao.Entities
{
    class ContaSalario : Conta
    {
        public string NameEnterprise { get; set; }
        public double LoanLimit { get; set; }
   
        public ContaSalario() {
        }

        public ContaSalario (int numCont, string nameProp, DateTime dateOpen, double balance, string nameEnterprise, double loanLimit) : base(numCont, nameProp, dateOpen, balance) 
        {
            NameEnterprise = nameEnterprise;
            LoanLimit = loanLimit;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount); //Estipula preço a descontar por levantamento
            Balance -= amount * 0.15;
        }

        //Método Empréstimo que adicona valor pretendido com base no limite de crédito
        public void Loan(double amount)
        {
            if (amount <=  LoanLimit)
            {
                Balance += amount;
                LoanLimit -= amount;
            }
            else Console.WriteLine("Credit Limit Exceeded");
        }

        public override string ToString() {
            //Concatena com o toString da Classe Conta!!!
             return $"{base.ToString()}, Name Enterprise: {NameEnterprise}, LoanLimit: {LoanLimit.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }

   
}
