using system.collection.generic;

class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };


        //UNIAO
        SortedSet<int> c = new SortedSet<int>(a); //Instancia novo conjunto c, com base no conjunto a
        c.UnionWith(b); //Uniao de C com B, sem repeti��es!!
        PrintCollection(c);

        //Intersec��o
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b); //Apenas valores iguais nos dois conjuntos!!
        PrintCollection(d);

        //Diferen�a
        SortedSet<int> e = new SortedSet<int>(a); 
        e.ExceptWith(b); // Apenas valores distintos ser�o guardados!!
        PrintCollection(e);
    }

    //Fun��o tipo gen�rica, o IEnumerable � um padr�o de projeto, para voc� percorrer cole��es de uma forma padronizada
    //A cole��o passada como argumento � do tipo T(gen�rica), que implementa o IEnumerable
    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection) {
            Console.WriteLine(item + " ");
    }
}