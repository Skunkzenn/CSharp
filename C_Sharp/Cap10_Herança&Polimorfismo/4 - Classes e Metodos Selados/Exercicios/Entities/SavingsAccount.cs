namespace Exercicios.Entities
{   //SavingsAccount vai herdar tudo o que a classe account tem
    //Classe passou a ser selada, evitando assim que a classe seja herdada
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }
       
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Sobscrever a operação, todas as operações de super-classes que estão marcadas com a palavra virtual podem ser editadas diretamente
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        //Utilizando a palavra BASE
        //Só podemos selar métodos sobrepostos, como este Withdraw, que já foi sobreposto (overide)
        public sealed override void Withdraw(double amount)
        {
            //Com o 'base' conseguimos reaproveitar a operação da super classe e ainda adicionar outras operações
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
