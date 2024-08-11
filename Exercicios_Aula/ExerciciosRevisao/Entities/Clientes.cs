using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRevisao.Entities
{
    class Cliente
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        
        public Cliente() { }

        public Cliente(int clientId, string name)
        {
            Name = name;
            ClientId = clientId;
        }

        public override string ToString()
        {
            return $"Nº Conta: {ClientId}, Cliente: {Name}";
        }
    }
}
