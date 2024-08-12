using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            /* O problema no reuso, será porque que temos uma tipologia específica na classe PrintService, ou seja, para cada tipo, teríamos que construir um novo sistema para a leitura
             * se eu quisesse um printservice de string? de double?... de tal modo, temos de ter um tipo genérico para controlar essa situação, assim teremos reuso sob a classe PrintService.          
             */

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);                
            }
            
            printService.Print();
            Console.WriteLine("First: " + printService.First);

            /* Poderíamos definir tudo como object e assim resolver o problema... mas estaríamos a criar outro, relacionado com o type safety e perda de perfomance.
             * Definindo como object para inteiro, teríamos de fazer o casting manual, logo isso funcionaria muito bem, assim como para string...pois não temos garantia nenhuma do que está
             * a ser processado no PrintServic, vai ser um número, string, double??? logo o compilador não vai reconhecer esse erro e deixa-rá passar, podendo causar graves problemas,
             * pois o compilador sem alertar, muito dificilmente o programador vai conseguir encontrar o erro. Ao fim da execução, teremos um erro de Exception(InvalidCastException)
             
             * OBJECT NÃO TEM TYPE SAFETY!!! 
             
             */

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            int a = (int)printService.First();
            int b = a + 2;
            Console.Write(b);

        }
    }
}
