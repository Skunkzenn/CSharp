/* Modificador params 
 
 Suponha que se queira uma calculadora para calcular a soma de uma quantidadevariável de valores. 
 
 Solução ruim usando sobrecarga:
 
    namespace Course
    {
        class Calculator
        {
            public static int Sum(int n1, int n2)
            {
                return n1 + n2;
            }
            public static int Sum(int n1, int n2, int n3)
            {
                return n1 + n2 + n3;
            }
            public static int Sum(int n1, int n2, int n3, int n4)
            {
                return n1 + n2 + n3 + n4;
            }
        }
    }

    Porque é ruim? porque teria de criar infinitas sobrecargas para suprir as minhas necessidades. 
    Ficaremos sempre dependente de ter uma função com o número de parâmetros necessários.
    
Para essa situação ficar melhor, podemos aplicar em modo de vetores, no caso criariamos uma função soma que receberá um VETOR de números:
 */

namespace Course;

    class Calculator
    {                         //Função SOMA que recebe um VETOR de números 
                             //Ao utilizar o 'params' estamos a passar para o compilador que queremos uma função que possa receber uma quantia variada de valores 
        public static int Sum(params int[] numbers)
        {   //Logica para efetuar a soma
            int sum = 0;
                            //Percorre o vetor inteiro (o parametro Length pega o tamanho do vetor automaticamente)
            for (int i = 0; i < numbers.Length; i++)
            {   //Acumulando aqui os valores
                sum += numbers[i];
            }
            return sum;
        }
    }