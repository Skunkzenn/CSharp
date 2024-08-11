using Exercicio2.Entities;

namespace Exercicio2;

class Program
{
    public static void Main(string[] args)
    {
        Gato gato = new Gato("Elder", "Gemêos");
        Cao cao = new Cao("Pitomba", "Pitbull");
        
        Animal.listAnimals.Add(gato);
        Animal.listAnimals.Add(cao);

        foreach (Animal animal in Animal.GetAnimals())
        {
            Console.WriteLine(animal.FazerBarulho());
        }
    }
}