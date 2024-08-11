namespace Course;

class Pessoa
{
    private string _nome;
    private int _idade;

    public Pessoa()
    {

    }

    public Pessoa(string nome, int idade)
    {   
        _nome = nome;
        _idade = idade;
    }

    public string GetNome(){ return _nome; }

    public int GetIdade(){ return _idade; }

    public void SetNome(string nome) { _nome = nome; }

    public void SetIdade(int idade) { _idade = idade; }


    public override string ToString() {
    return _nome + ", " + _idade;
    }
}

