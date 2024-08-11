namespace Ex5_ImplementeClasses;

class Produto
{
    public string Nome { get; set; }

    public Produto() { 
    }

    public void setNome(string nome)
    {
        Nome = nome;
    }

    public string getNome()
    {
        return Nome;
    }

}
