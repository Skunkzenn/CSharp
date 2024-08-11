using Exercicio3_Class;

namespace Exercicio3_Classe;

class GestorEspetaculo
{
    //Fornece controle de como a lista é manipulada
    private List<Espetaculo> espetaculos;

    public GestorEspetaculo()
    {   //Encapsula a lista definindo os métodos publicos, garante que operações na lista, sejam realizadas de maneira segura;
        espetaculos = new List<Espetaculo>();
    }

    public void GuardarEspetaculo(Espetaculo espetaculo)
    {
        espetaculos.Add(espetaculo);
        Console.WriteLine($"Espetáculo: {espetaculo.Nome} guardado com sucesso");
    }

    public void ConsultarEspetaculos()
    {   //Chama a lista de espetaculos e exibe
        foreach (var espetaculo in espetaculos)
        {
            espetaculo.MostrarEspetaculo();
            Console.WriteLine();
        }
    }

    public void AdquirirBilhetes(string nomeEspetaculo, string nomeCliente, int quantidade)
    {
        Espetaculo espetaculo = espetaculos.Find(e => e.Nome == nomeEspetaculo);
        if (espetaculo != null)
        {
            // Se a quantidade solicitada for menor ou igual aos lugares disponíveis,
            // então a reserva pode ser feita.
            if (quantidade <= (espetaculo.NumLugares - espetaculo.LugaresReservados))
            {
                // Incrementa o número de lugares reservados no espetáculo.
                espetaculo.LugaresReservados += quantidade;
                // Cria um objeto Bilhete com o nome do cliente e a quantidade de lugares reservados.
                Bilhete bilhete = new Bilhete(nomeCliente, quantidade);
                bilhete.MostrarDetalhes();
            }
            else
            {
                Console.WriteLine("Não há lugares suficientes disponíveis.");
            }
        }
        else
        {
            Console.WriteLine("Espetáculo não encontrado.");
        }
    }
}

