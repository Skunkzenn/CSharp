using Exercicio2_Interface.Entities;

using System.Collections.Generic;

namespace Exercicio2_Interface;

class Program
{
    public static void Main(string[] args)
    {
        //Adiciona atributos a classe
        Conta cBanc1 = new Conta(1, "Victor", DateTime.Parse("20/10/2020"), 1000.44);
        Conta cBanc2 = new Conta(2, "Destefani", DateTime.Parse("20/09/1993"), 50000.59);
        Conta cBanc3 = new Conta(3, "Carmo", DateTime.Parse("10/06/1960"), 1000000.00);

        //Adiciona objetos na lista
        cBanc1.InsertElement(cBanc1);
        cBanc2.InsertElement(cBanc2);
        cBanc3.InsertElement(cBanc3);
        Console.WriteLine("Lista Original: ");
        foreach (Conta conta in Conta.GetListBank())
        {
            Console.WriteLine(conta);
        }
        Console.WriteLine();


        //Remove Elemento com Id 2 da lista
        cBanc2.RemoveElement(2);
        Console.WriteLine("Remove conta 2 da lista: ");
        foreach (Conta conta in Conta.GetListBank())
        {
            Console.WriteLine(conta);
        }
        Console.WriteLine();

        Console.WriteLine("Altera a conta 3 com novos dados: ");
        Conta newCbanc2 = new Conta(3, "Parracho", DateTime.Parse("20/09/1960"), 100.50);
        Conta newCbanc3 = new Conta(10, "Joselito", DateTime.Parse("20/09/1960"), 22000.50);
        if (cBanc3.UpdateElement(newCbanc2))
        {
            foreach (Conta conta in Conta.GetListBank())
            {
                Console.WriteLine(conta);
            }
        }
        else { Console.WriteLine("Conta inexistente"); }
        Console.WriteLine();

        Console.WriteLine("Alteração de conta por NumberAcc inexistente: ");
        if (cBanc1.UpdateElement(newCbanc3)) {
            foreach (Conta conta in Conta.GetListBank())
            {
                Console.WriteLine(conta);
            }
        }
        else { Console.WriteLine("Conta inexistente"); }

       
        List<Conta> selectAcc = cBanc1.SelectElements(typeof(Conta), 10);
        if (selectAcc != null)
        {
            Console.WriteLine("Lista de Contas:");
            foreach (Conta conta in selectAcc)
            {
                Console.WriteLine(conta);
            }
        }
        else
        {
            Console.WriteLine("Tipo de conta não reconhecido. ");
        }



    }
}