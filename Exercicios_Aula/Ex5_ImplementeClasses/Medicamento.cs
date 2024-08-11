namespace Ex5_ImplementeClasses;

class Medicamento : Produto
{
    public int Lote { get; set; }

    public Medicamento() { }

    public void setLote(int lote)
    {
        Lote = lote;
    }

    public int getLote() { 
        return Lote; 
    }
}
