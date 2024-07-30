namespace Ex3_Veiculo;

class Program
{
    public static void Main(string[] args)
    {
        Carro carro1 = new Carro("Citroen", "C3", 5);
        Mota mota1 = new Mota("Kawasaki", "Jaspion", 1100);

        Veiculo.listVeiculos.Add(mota1);
        Veiculo.listVeiculos.Add(carro1);

        foreach (Veiculo obj in Veiculo.GetVeiculos())
        {
            Console.WriteLine(obj);
        }
    }
}