using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_C_.Nullable
{
    class Nullable_DadosParamentros_Opcionais
    {
        /*Nullable
        • É um recurso de C# para que dados de tipo valor (structs) possam
        receber o valor null
        • Uso comum:
        • Campos de banco de dados que podem valer nulo (data de nascimento,
        algum valor numérico, etc.).
        • Dados e parâmetros opcionais. */

        static void Main(string[] args)
        {   //dará error pq double é um tipo valor, dará error, não podendo atribuir valor null para double
            //double x = null;


            //Para reverter:
            //Nullable<double> x = null;

            //Ou, assim estaremos a dizer que var é tipo double, mas opcional
            double? x = null;
            double? y = 10.0;

            //Vai imprimir o valor do X ou então se o valor não existir, pega o valor padrão da var x, ou seja, o valor padrão da var double, que será 0
            Console.WriteLine(x.GetValueOrDefault());
            //Vai imprimir o valor 10, pois o valor padrao da var y está setado como 10, se não tivesse nada, pegaria o valor 0
            Console.WriteLine(y.GetValueOrDefault());

            //Vai dizer se dentro da var x, existe ou não um valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Como se pegasse o valor diretamente do x
            //A operação value, lança uma exceção, dará erro se você tentar chamar ela a partir de um objeto que esta nullable, nesse caso, teriamos que usar um if
            //SE TEM VALOR(HASVALUE) NO X, EU VOU MANDAR IMPRIMIR O VALOR
            if (x.HasValue) Console.WriteLine(x.Value);
            else Console.WriteLine("X is NULL");

            if (y.HasValue) Console.WriteLine(y.Value);
            else Console.WriteLine("Y is NULL");

            /* Operador de coalescência nula '??' */

            double? x = null;
                        //Ele vai fazer o seguinte, temos a var x do tipo double nullable
                        //Temos um var y que não é nullable e queremos jogar em y o valor de x
                        //Caso o x seja nulo, nós jogamos outro valor, o valor que estiver a direita.
                        //E para isso que serve a operação, se x não for nulo, joga o valor de x, se for nulo, joga o valor a direita.
            double y = x ?? 0.0;
        }
    }
}
