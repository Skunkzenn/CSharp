using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Entities
{
    class Cao : Animal
    {
        public string Raca { get; set; }
        public Cao() { }
        public Cao(string nome, string raca) : base(nome) {  Raca = raca; }
        public override string FazerBarulho()
        {
            return "auau";
        }

        public override string ToString()
        {
            return base.ToString() + " " + Raca;
        }

    }
}
