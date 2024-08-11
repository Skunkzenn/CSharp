using ExerciciosRevisao.Entities;
using System.Collections.Generic;

namespace ExerciciosRevisao;

class Program
{
    public static void Main(string[] args)
    {
        //Instância Classes
        List<Conta> listBancaria = new List<Conta>();
        List<ContaPoupanca> listPoupanca = new List<ContaPoupanca>();
        List<ContaSalario> listSalario = new List<ContaSalario>();
        List<Cliente> listClientes = new List<Cliente>();


        //Inicia parâmetros
        Console.WriteLine("Inicia parâmetros das classes:");
        Cliente cli1 = new Cliente(1, "Victor");
        Conta cBanc = new Conta(1, "Victor", DateTime.Parse("20/10/2020"), 1000.10);
        ContaPoupanca cPoup = new ContaPoupanca(1, "Alfredo", DateTime.Parse("08/02/1978"), 3000.00);
        ContaPoupanca cPoup1 = new ContaPoupanca(2, "Sampaio", DateTime.Parse("22/04/1944"), 5000.00);
        ContaSalario cSal = new ContaSalario(1, "Jubileu", DateTime.Parse("20/11/2010"), 777.89, "EDP", 3000.00);
        ContaSalario cSal1 = new ContaSalario(2, "Jussara", DateTime.Parse("10/08/2006"), 800.00, "IPCA", 1000.00);

        //Adiciona objetos na lista
        listClientes.Add(cli1);
        listBancaria.Add(cBanc);
        listPoupanca.Add(cPoup);
        listPoupanca.Add(cPoup1);
        listSalario.Add(cSal);
        listSalario.Add(cSal1);
        
        //Imprime Objetos
        Console.WriteLine(cli1);
        Console.WriteLine(cBanc);
        Console.WriteLine(cPoup);
        Console.WriteLine(cPoup1);
        Console.WriteLine(cSal);
        Console.WriteLine(cSal1);
        

        Console.WriteLine();
        Console.WriteLine("Alteração em objetos das listas:");

        Console.WriteLine("Conta Salário Demostração:");

        #region AlteracaoContaSalario

        //Passa id para procurar na lista de poupança e utiliza método Deposti para adicionar valor
        int idSalario = 1;
        ContaSalario contS = listSalario.Find(e => e.NumberAcc == idSalario);
        if (contS != null)
        {
            contS.Withdraw(400.00);
            //contS.Loan(300.00);
        }

        int idSalario2 = 2;
        ContaSalario contS1 = listSalario.Find(e => e.NumberAcc == idSalario2);
        if (contS1 != null) 
        {
            contS1.Loan(800.00); 
        }

        //Corre toda a lista da poupança e imprime os objetos contidos.
        foreach (ContaSalario obj in listSalario)
        {
            Console.WriteLine(obj);
        }

        #endregion
        Console.WriteLine();
        Console.WriteLine("Conta Poupança Demonstração");

        #region AlteracaoContaPoupanca
        //Passa id para procurar na lista de poupança e utiliza método Deposti para adicionar valor
        int idPoupanca = 1;
        ContaPoupanca contP = listPoupanca.Find(e => e.NumberAcc == idPoupanca);
        if (contP != null)
        {
            contP.Deposit(400.00);
        }

        int idPoupanca2 = 2;
        ContaPoupanca contP2 = listPoupanca.Find(e => e.NumberAcc == idPoupanca2);
        if (contP2 != null)
        {
            contP2.Withdraw(400.00);
        }

        //Corre toda a lista da poupança e imprime os objetos contidos.
        foreach (ContaPoupanca obj in listPoupanca)
        {
            Console.WriteLine(obj);
        }

        #endregion

    }
}