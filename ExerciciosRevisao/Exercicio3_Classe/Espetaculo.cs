namespace Exercicio3_Class;
class Espetaculo
{
    public string Nome { get; set; }
    public string Sala { get; set; }
    public DateTime DataExi { get; set; }
    public int NumLugares { get; set; }
    public int LugaresReservados { get; set; }

    public Espetaculo() { }
    public Espetaculo(string nome, string sala, DateTime dateTime, int numLugares)
    {
        Nome = nome;
        Sala = sala;
        DataExi = dateTime;
        NumLugares = numLugares;
        //Passar como 0, para inicio
        LugaresReservados = 0;
    }  
    
    public void MostrarEspetaculo() {
        Console.WriteLine(
            $"Nome: {Nome}\nSala: {Sala}\nData Exibição: {DataExi}\nNº de lugares: {NumLugares}\nNº lugares reservados: {LugaresReservados}");
    }
}
