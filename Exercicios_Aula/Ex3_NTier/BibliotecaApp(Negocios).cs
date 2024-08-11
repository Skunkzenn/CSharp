using System;
using System.Collections.Generic;

class BibliotecaApp
{
    private AcessodeDados bibliotecaService;

    public BibliotecaApp()
    {
        bibliotecaService = new AcessodeDados();
    }

    public void ListarLivros()
    {
        List<Livro> livros = bibliotecaService.ObterTodosLivros();

        Console.WriteLine("\nLista de Livros:");
        foreach (var livro in livros)
        {
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}");
        }
        Console.WriteLine();
    }

    public void AdicionarLivro(Livro livro)
    {
        bibliotecaService.AdicionarLivro(livro);
        Console.WriteLine("Livro adicionado com sucesso!\n");
    }
}
