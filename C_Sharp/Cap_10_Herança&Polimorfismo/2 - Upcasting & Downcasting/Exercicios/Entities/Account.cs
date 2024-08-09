namespace CSharp.Cap10_Herança_Polimorfismo.ExercicioHeranca.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        //Modificador de acesso 'PROTECTED' - valor só pode ser alterado dentro da classe, ou por uma subclasse, mas no programa principal não podemos alterar o seu valor;
        public double Balance { get; protected set; }
    
        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }

    
}
