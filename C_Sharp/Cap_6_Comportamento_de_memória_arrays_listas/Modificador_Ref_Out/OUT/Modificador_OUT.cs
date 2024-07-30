/* Modificador out 
 
 
 O modificador out é similar ao ref (faz o parâmetro ser uma referência para a variável original), mas não exige que a variável original seja iniciada.

 */



class Calculator
{                           //inicia a função com uma var de origem e outra para resultado
    public static void Triple(int origin, out int result)
    {   //resultado recebe a origem * 3;
        result = origin * 3;
    }
}

