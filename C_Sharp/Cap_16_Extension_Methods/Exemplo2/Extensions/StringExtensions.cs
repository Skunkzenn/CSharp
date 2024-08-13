namespace System //Colocar o namespace da extension methods em system, facilita na chamada para as demais classes
{
    static class StringExtensions
    {                           //Metodo Cut recebe um objeto, mais um número inteiro            
        public static string Cut(this string thisObj, int count)
        {   //Se o string original já ter um tamanho menor que o valor que queremos contar, não precisamos realizar a operação
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