using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Entities
{
    class Animal
    {
        public static List<Animal> listAnimals  = new List<Animal>();
        public string Nome { get; set; }

        public Animal() { }
        public Animal(string nome) { Nome = nome; }

        public static List<Animal> GetAnimals() { 
            return listAnimals; 
        }

        public virtual string FazerBarulho()
        {
            return "Qual barulho? ";
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
