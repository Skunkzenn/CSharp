using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_C_.DesalocacaoMemoria
{
    class Desalocacao_por_Escopo
    {
        static void Main(string[] args)
        {
            void method1()
            {
                int x = 10;
                //Quando validar, vai ser criada uma variada y, dentro do scopo if, que está dentro do método 1, fazendo o y valer 20, mas imediatamente quando sair do if, a variável do y vai desaparecer. Ou seja, imediatamente alocadas e logo quando saímos do escopo elas são desalocadas.
                if (x > 0) { 
                int y = 20;}
                Console.WriteLine(x);
            }

            void method2()
            {
                //Foi declarada um var product p, sendo criada no stack, mas ela vai receber o resultado do method3, como acontece uma chamada do outro metodo
                //Agora como o p toma o valor de method3()
                Product p = method3();
                //p vai apontar para os valores obtidos no method3 e o scopo do method2 vai desaparecer
                Console.WriteLine(p.Name);
            }

            //Quando o method3() foi criado, imediatamente foi criado o scopo dele, foi criada a var prod la dentro, durante o processamento ouve um instanciação
            //Que mesmo finalizando o scopo do method3 a referência vai continuar lá, o objeto product vai continuar existindo pq vai continuar a existir a referencia para ele, ele não será desalocado pelo garbage collector.

            Product method3()
            {//Vai ser criada o scopo do method3 no stack, dentro do method3 vai ter uma outra var prod, do tipo product, que vai receber new Product("TV", 900.00, 0);
                //nesse momento teremos uma variável prod do tipo product apontando para o novo objeto product que acabou de ser instanciado.
                Product prod = new Product("TV", 900.00, 0);
                return prod;
            }
            
        }
    }
}
