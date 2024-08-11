namespace Ex4_IntegracaoExercicios;

class Negocios
{
    public AcessodeDados negociosServico { get; set; }

    public Negocios ()
    {
        negociosServico = new AcessodeDados();
    }

    public void ListarContatos()
    {
        List<Contatos> contatos = negociosServico.ObterContatos();

        Console.WriteLine("\nLista de Contatos:");
        foreach (Contatos obj in contatos)
        {
            Console.WriteLine($"{obj.Nome}, {obj.NTelefone}");
        }
        Console.WriteLine();
    }

    public void AdicionaContato(Contatos contatos)
    {
        negociosServico.AdicionarContato(contatos);
        Console.WriteLine("Contato adicionado com sucesso!\n");
    }

    public void SaveContatos(List<Contatos> contatos, string fileName)
    {
        negociosServico.SaveContatosService(contatos, fileName);
    }

    public void LoadContatos(string fileName)
    {
        negociosServico.LoadContatosService(fileName);
    }
}


