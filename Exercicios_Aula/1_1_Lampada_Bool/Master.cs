namespace Exercicios_Em_Aula.ExerciciosAulaPOO.Lampada_Bool;

class Master
{
    static void Main(string[] args)
    {
        Lampada lampada = new Lampada();

        lampada.Apagar();
        lampada.Estado();

        Console.WriteLine("Estado: " + lampada.Estado());

        lampada.Acender();
        Console.WriteLine("Estado: " + lampada.Estado());
    }
}
