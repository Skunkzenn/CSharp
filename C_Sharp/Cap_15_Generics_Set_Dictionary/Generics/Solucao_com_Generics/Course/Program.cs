using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Agora basta instânciar de acordo com o tipo que deseja, seja string, int, double... etc
            //Se você tentar fazer o casting agora, com valores incorretos na atribuição, o compilador vai te retornar os erros referentes ao type-safety
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            //Não é preciso realizar o casting pois o printservice já foi parâmetrizado como int, ou seja, o compilador já vai perceber que é um inteiro a ser retornado.
            int a = /*(int)*/printService.First();
            int b = a + 2;
            Console.Write(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
