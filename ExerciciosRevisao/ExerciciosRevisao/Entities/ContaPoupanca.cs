using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRevisao.Entities
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca() { }

        public ContaPoupanca(int numCont, string nameProp, DateTime dateOpen, double balance) : base(numCont, nameProp, dateOpen, balance) 
        {
        }

        public override void Deposit(double deposit)
        {   //A cada deposito é atribuído bonus de 5%
            base.Deposit(deposit += deposit * 0.05);
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount + (amount * 0.20));
        }

        public override string ToString()
        {
            //Concatena com o toString da Classe Conta!!!
            return $"{base.ToString()}";
        }
    }
}
