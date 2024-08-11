namespace Ex5_ImplementeClasses;

class Perfume : Produto
{
    public string Fragrancia { get; set; }

    public Perfume() { 
    }

    public void setLote(string fragrancia)
    {
        Fragrancia = fragrancia;
    }

    public string getLote()
    {
        return Fragrancia;
    }
}
