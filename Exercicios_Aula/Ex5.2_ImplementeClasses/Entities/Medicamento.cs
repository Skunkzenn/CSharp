using Ex5._2_ImplementeClasses.Interfaces;

namespace Ex5._2_ImplementeClasses.Entities;

class Medicamento : BasedeDados
{
    public static List<Medicamento> listMedicamentos = new List<Medicamento>();
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public float Preco { get; set; }

    public Medicamento() { }
    public Medicamento(int codigo, string nome, string descricao, float preco)
    {
        Codigo = codigo;
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
    }

    public void inserir()
    {
        listMedicamentos.Add(this);
    }
    public void atualizar()
    {
        Medicamento medicamentoAtualiza = listMedicamentos.Find(x => x.Codigo == Codigo);
        if (medicamentoAtualiza != null)
        {
            medicamentoAtualiza.Nome = Nome;
            medicamentoAtualiza.Descricao = Descricao;
            medicamentoAtualiza.Preco = Preco;
        }
        else Console.WriteLine("Pedido não encontrado.");
    }
    public void apagar()
    {
        Medicamento medicamentoApaga = listMedicamentos.Find(x => x.Codigo == Codigo);
        if (medicamentoApaga != null)
        {
            listMedicamentos.Remove(medicamentoApaga);
        }
        else Console.WriteLine("Nada encontrado para eliminar");
    }
    public void procurar()
    {
        Medicamento medicamentoProcura = listMedicamentos.Find(x => x.Codigo == Codigo);
        if (medicamentoProcura != null)
        {
            Console.WriteLine($"Medicamento >{Codigo}< encontrado: Nome: {medicamentoProcura.Nome}, Descrição: {medicamentoProcura.Descricao}, Preço: {medicamentoProcura.Preco}");
        }
        else
        {
            Console.WriteLine($"Medicamento {Codigo} não encontrado.");
    
        }
    }
}
