/* Modificador ref
    
    Suponha que se queira uma calculadora com uma operação para triplicar o valor de um número passado como parâmetro. 
    A seguir uma solução que não funciona:
 */


class Calculator
{
    public static void Triple(ref int x)
    {   //Se fizermos x = x * 3 e no programa principal passar o valor para esse x, a operação não vai funcionar, porque não será a var no master que irá armazenar o valor, mas sim o X.
        //Para se contornar a situação, devemos utilizar o ref, que vai referenciar o objeto, ou seja, o parâmetro X vai se tornar uma referência para a variavel original
        x = x * 3;
    }
}

