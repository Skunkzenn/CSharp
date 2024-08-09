namespace Exercicios.Entities
{         //BusinessAccount terá todos os atributos que a classe Account tem  
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        //Devemos ter atenção aos parâmetros de entrada do construtor 'Account' para ser copiado corretamente os parâmetros do construtor
                                                                                             //  Chamar o construtor com argumentos da classe Account
                                                                                             //  Aproveitando o construtor da base!
        public BusinessAccount(int number, string holder, double balance, double loanLimite) : base(number, holder, balance)
        {
            //Aciona construtor account para fazermos o reu-so, apenas passando a nova propriedade
            LoanLimit = loanLimite;
        }

        public void Loan (double amount)
        {
            //como existe um limite para o empréstimo, deve-se realizar verificação.
            if (amount <= LoanLimit)
            Balance += amount;
        }
    }
}
