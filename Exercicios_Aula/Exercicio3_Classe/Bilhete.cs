using Exercicio3_Class;

namespace Exercicio3_Classe;
class Bilhete
{
    public string NomeCliente { get; set; }
    public int Quantidade { get; set; }

    public Bilhete() { }
    public Bilhete(string nomeCliente, int quantidade)
    {
        NomeCliente = nomeCliente;
        Quantidade = quantidade;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Nome cliente: {NomeCliente}\nQuantidade: {Quantidade}");
    }
 }
