namespace System //Colocar o namespace da extension methods em system, facilita na chamada para as demais classes
{
    static class StringExtensions
    {                           //Metodo Cut recebe um objeto, mais um n�mero inteiro            
        public static string Cut(this string thisObj, int count)
        {   //Se o string original j� ter um tamanho menor que o valor que queremos contar, n�o precisamos realizar a opera��o
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {          //De onde estou, para onde vou     
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}