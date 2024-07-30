namespace Exercicios_Em_Aula.ExerciciosAulaPOO.Triangulo;

class Triangulo
{
    private double ladoA;
    private double ladoB;
    private double ladoC;

    public Triangulo()
    {
        ladoA = 0.00;
        ladoB = 0.00;
        ladoC = 0.00;
    }

    public void Dimensoes(double a, double b, double c)
    {
        ladoA = a;
        ladoB = b;
        ladoC = c;
    }

    public string Tipo()
    {
        if (ladoA == ladoB && ladoB == ladoC) return "equilátero";
        else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC) return "escaleno";
        else return "Isósceles";
    }



}