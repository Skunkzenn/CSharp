using System;

namespace Ex3_Veiculo
{
    class Mota : Veiculo
    {
        public int Cilindrada { get; set; }
        public Mota() { }
        public Mota(string marca, string modelo, int cilindrada) : base(marca, modelo) {
            Cilindrada = cilindrada;
        }
    
        public override string ToString() {
            return $"{base.ToString()}Cilindrada: {Cilindrada}cc";
        }
    }
}
