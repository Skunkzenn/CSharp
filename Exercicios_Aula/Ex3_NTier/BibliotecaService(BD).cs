using System.Collections.Generic;

class AcessodeDados
{
    private List<Livro> livros;

    public AcessodeDados() 
    {
        livros = new List<Livro>();
    }

    public List<Livro> ObterTodosLivros()
    {
        return livros;
    }

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

}


