
using CSharp.Cap10_Herança_Polimorfismo.ExercicioHeranca.Entities;

namespace CSharp.Cap10_Herança_Polimorfismo._2___Upcasting___Downcasting.Exercicios.Entities
{   //SavingsAccount vai herdar tudo o que a classe account tem
    class SavingsAccount : Account
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
    }
}
