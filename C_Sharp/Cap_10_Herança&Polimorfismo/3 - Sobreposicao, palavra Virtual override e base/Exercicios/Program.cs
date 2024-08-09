using System;

using CSharp.Cap10_Herança_Polimorfismo._2___Upcasting___Downcasting.Exercicios.Entities;

namespace CSharp.Cap10_Herança_Polimorfismo.ExercicioHeranca.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //Upcasting - Conversão da subclasse para superclasse, como temos uma relação 'é-um' o businnesaccount é uma account.
            //Uma classe que forneça herença para outras, recebe um objeto qualquer tipo de subclasse dela; Isso é chamado de Upcasting
            Account account1 = businessAccount;
            //Também podemos fazer um new na sub-classe, instanciando e atribuindo o valor a super-classe
            Account account2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //O mesmo exemplo que o de cima, mas utilizando o SavingAccount
            Account account3 = new SavingsAccount(10, "Joana", 0.0, 0.01);

            //Downcasting - Conversão da superclasse para subclasse - é uma operação insegura, somente devemos utilizar quando realmente for necessário e
            //devemos testes a variavel se é realmente do tipo que queremos.
            //Só funcionará a conversão, se declarar-mos como casting, antes da variável, conforme exemplo.
            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.50);

            //Dará erro porque a operação Loan não é da super-classe, sendo apenas da sub-classe, só sendo possível fazer loan, quando realizar o Downcasting
            //account2.Loan(100);

            //Dará erro pois não pode converter de accout para BusinessAccount, sendo preciso fazer o casting do mesmo
            //BusinessAccount acc5 = account3;
           
            //Dará erro na execução, pois o 'account3' é uma variavel da SavingsAccount e não da BusinessAccount
            //BusinessAccount acc6 = (BusinessAccount)account3;

            //Para testar as variáveis fazemos: se a variavel acc3 for uma instancia de business account..
            if (account3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)account3;
                
                //Outra forma de fazer o casting
                BusinessAccount acc6 = account3 as BusinessAccount;

                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (account3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)account3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }


        }
    }
}
