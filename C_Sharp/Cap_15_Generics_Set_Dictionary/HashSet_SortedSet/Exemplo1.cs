using system.collection.generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string> ();
        set.Add("TV");
        set.Add("NOTEBOOK");
        set.Add("TABLET");

        //Dará true
        Console.WriteLine(set.Contains("NOTEBOOK"));

        //Dará false
        Console.WriteLine(set.Contains("COMPUTER"));

        /* Como o conjunto não tem a condição da posição,
           temos de partir pelo foreach, que vai percorrer os 
           elementos do conjunto de forma interna */
        foreach (string s in set)
        {
            Console.WriteLine(s);
        }
}