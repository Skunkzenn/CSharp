/* Desenvolva um programa EM C# que utilize as listas para fazer a gestão de uma lista de contatos.
Cada contato deve ter um nome e um número de telefone. O programa deve permitir ao
utilizador realizar as seguintes operações: 

 Adicionar um novo contato.
• Mostrar a lista de contatos.
• Pesquisar um contato pelo nome.
• Remover um contato.

*/

using Ex1_Listas;

namespace Ex1_Listas;
class Program
{
    static void Main(string[] args)
    {
        List<Contatos> listContatos = new List<Contatos>();
        Contatos contatos1 = new Contatos("Victor", 961723874);
        Contatos contatos2 = new Contatos("Carmo", 965785325);

        //Adiciona novo contacto
        listContatos.Add(contatos1);
        listContatos.Add(contatos2);
        Console.WriteLine();

        Console.WriteLine("ListaContatos");
        //Percorre lista contatos
        foreach (Contatos contato in listContatos)
        {
            Console.WriteLine(contato);
        }

        Console.WriteLine();
        Console.WriteLine("BuscaContato");
        //Busca contacto
        //Contatos contatoLocaliza = listContatos.Find(x => x.Nome == "Victor");
        Contatos contatoLocaliza = listContatos.Find(x => x.Nome == "Victor");
        Console.WriteLine(contatoLocaliza);
        /* //Imprime 2x método para encontrar contato
        foreach (Contatos contato in listContatos)
        {

            if (contatoLocaliza != null)
            {
                Console.WriteLine(contatoLocaliza);
            }
            else Console.WriteLine("Nada encontrado");
        }
        */

        Console.WriteLine();
        Console.WriteLine("RemoveContacto");
        //RemoveContacto
        listContatos.Remove(contatos1);
        foreach (Contatos contato in listContatos)
        {

            Console.WriteLine(contato);
        }


    }
}