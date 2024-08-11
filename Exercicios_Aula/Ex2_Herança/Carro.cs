namespace Ex2_Herança
{
    class Carro : Veiculo
    {
        public int Lugares { get; set; }
        public Carro() { }
        public Carro(string marca, string modelo, int lugares) : base(marca, modelo) {  
            Lugares = lugares; 
        }
        public override string ToString()
        {
            return $"{base.ToString()}Lugares: {Lugares}";
        }
    }
}
