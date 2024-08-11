namespace Course;

class Pessoa
{
    private string Nome;
    private int Idade;

    public Pessoa()
    {

    }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(int idade)
    {
        Idade = idade;
    }

    public Pessoa(string nome, int idade)
    {   
        Nome = nome;
        Idade = idade;
    }

    public override string ToString() {
    return Nome + ", " + Idade;
    }
}

