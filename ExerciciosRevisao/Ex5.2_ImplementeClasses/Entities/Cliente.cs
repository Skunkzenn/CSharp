using Ex5._2_ImplementeClasses.Interfaces;

namespace Ex5._2_ImplementeClasses.Entities
{
    class Cliente : BasedeDados
    {
        public static List<Cliente> listClientes = new List<Cliente>();
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Nif { get; set; }

        public Cliente() { }
        public Cliente(int codigo, string nome, string telefone, string nif)
        {
            Codigo = codigo;
            Nome = nome;
            Telefone = telefone;
            Nif = nif;
        }

        public void inserir() { 
            listClientes.Add(this);
        }
        public void atualizar() { 
            Cliente clienteAtualiza = listClientes.Find(x => x.Codigo == Codigo);
            if (clienteAtualiza != null)
            {
                clienteAtualiza.Nome = Nome;
                clienteAtualiza.Telefone = Telefone;
                clienteAtualiza.Nif = Nif;
            }
            else Console.WriteLine("Cliente não encontrado.");
        }
        public void apagar() {
            Cliente clienteRemove = listClientes.Find(x => x.Codigo == Codigo);
            if(clienteRemove != null)
            {
                listClientes.Remove(clienteRemove);
            }
        }
        public void procurar() {
            Cliente procuraCliente = listClientes.Find(x => x.Codigo == Codigo);
            if (procuraCliente != null)
            {
                Console.WriteLine($"Cliente >{Codigo}< encontrado: Nome: {procuraCliente.Nome}, Telefone: {procuraCliente.Telefone}, NIF: {procuraCliente.Nif}");
            }
            else Console.WriteLine("Cliente não encontrado.");
        }
    }
}
