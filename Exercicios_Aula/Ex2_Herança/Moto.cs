namespace Ex2_Herança
{
    class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public Moto() { }
        public Moto(string marca, string modelo, int cilindrada) :base(marca, modelo)
        {
            Cilindrada = cilindrada;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Cilindrada: {Cilindrada}cc";
        }
    }
}
