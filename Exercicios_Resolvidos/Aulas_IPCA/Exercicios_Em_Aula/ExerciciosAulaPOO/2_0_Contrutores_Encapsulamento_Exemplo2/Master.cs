using Course;
using System.Globalization;

namespace Exercicios_Em_Aula;

class Master
{
    static void Main(string[] args)
    {
        Pessoa pes1, pes2, pes3, pes4 = new Pessoa();

        //pes1 = new Pessoa("Jo�o Silva");
        //pes1 = new Pessoa(18);

        pes1 = new Pessoa("Jo�o Silva", 18);
        pes2 = new Pessoa("Jo�o Kl�ber", 19);
        pes3 = new Pessoa("Xuruminho Kl�ber", 25);
        pes4 = new Pessoa("Senhor me Ajuda em POO", 30);

        Console.WriteLine($"{pes1}\n{pes2}\n{pes3}\n{pes4}");

        pes1.SetNome("Jo�o Kleber");
        pes1.SetIdade(99);

        Console.WriteLine(pes1);

    }
}
