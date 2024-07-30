namespace Ex4_IntegracaoExercicios;
[Serializable]


class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(){}

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}";
        }
    }