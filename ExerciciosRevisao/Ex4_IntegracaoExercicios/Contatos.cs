namespace Ex4_IntegracaoExercicios;
[Serializable]
class Contatos : Pessoa
{
    public int NTelefone { get; set; }

    public Contatos() { }
    public Contatos(string nome, int nTelefone):base(nome) {
        NTelefone = nTelefone;
    }

    public override string ToString()
    {
        return $"{base.ToString()} | Contacto: {NTelefone}";
    }
}
