namespace Ex5_ImplementeClasses;

class MedicamentoGenerico : Medicamento
{
    string Dci { get; set; }

    public void setDci(string dci)
    {
        Dci = dci;
    }
    public string getDci() { 
        return Dci;
    }
}
