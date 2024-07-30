using System;
using Course.Entities;

namespace CSharp.Cap10_Herança_Polimorfismo.ExercicioHeranca.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(80100, "Bob Brown", 100.5, 500.00);
            Console.WriteLine(account);

            //Será impossível modificar o valor na master
            account.Balance = 50;
        }
    }
}
