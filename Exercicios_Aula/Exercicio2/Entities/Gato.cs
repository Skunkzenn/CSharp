using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Entities
{
    class Gato : Animal
    {
        public string Raca { get; set;}
        public Gato() { }
        public Gato(string nome, string raca) : base(nome)
        {
            Raca = raca;
        }

        public override string FazerBarulho()
        {
            return "miau";
        }

        public override string ToString()
        {
            return base.ToString() + " " + Raca;
        }
    }
}
