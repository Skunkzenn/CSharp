namespace Ex1_Listas
{
    class Contatos
    {
        public string Nome { get; set; }
        public int NTelefone { get; set; }

        public Contatos() { }
        public Contatos(string nome, int nTelefone) {
            Nome = nome;
            NTelefone = nTelefone;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Contacto: {NTelefone}";
        }
    }
}
