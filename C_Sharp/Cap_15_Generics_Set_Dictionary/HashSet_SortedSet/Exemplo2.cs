using system.collection.generic;

class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };


        //UNIAO
        SortedSet<int> c = new SortedSet<int>(a); //Instancia novo conjunto c, com base no conjunto a
        c.UnionWith(b); //Uniao de C com B, sem repetições!!
        PrintCollection(c);

        //Intersecção
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b); //Apenas valores iguais nos dois conjuntos!!
        PrintCollection(d);

        //Diferença
        SortedSet<int> e = new SortedSet<int>(a); 
        e.ExceptWith(b); // Apenas valores distintos serão guardados!!
        PrintCollection(e);
    }

    //Função tipo genérica, o IEnumerable é um padrão de projeto, para você percorrer coleções de uma forma padronizada
    //A coleção passada como argumento é do tipo T(genérica), que implementa o IEnumerable
    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection) {
            Console.WriteLine(item + " ");
    }
}