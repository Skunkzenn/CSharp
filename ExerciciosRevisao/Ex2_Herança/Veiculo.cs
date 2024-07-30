using System.Reflection;

namespace Ex2_Herança
{
    class Veiculo
    {
        public static List<Veiculo> listVeiculos = new List<Veiculo>();
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Veiculo() { }
        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public List<Veiculo> GetVeiculos() { return listVeiculos; }

        public override string ToString()
        {
            return $"Marca: {Marca}\nModelo: {Modelo}\n";
        }
    }
}
