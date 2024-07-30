using System;

namespace Ex3_Veiculo
{
    class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

        public Carro() { }
        public Carro(string marca, string modelo, int numeroDePortas) : base(marca, modelo)
        {
            NumeroDePortas = numeroDePortas;  
        }

        public override string ToString()
        {
            return $"{base.ToString()}Nº Portas: {NumeroDePortas}";
        }
    }
}
