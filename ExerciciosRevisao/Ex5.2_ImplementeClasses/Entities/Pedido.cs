using Ex5._2_ImplementeClasses.Interfaces;

namespace Ex5._2_ImplementeClasses.Entities
{
    class Pedido : Legislacao, BasedeDados
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public float Valor { get; set; }

        private static List<Pedido> listaPedidos = new List<Pedido>();

        public Pedido() { }
        public Pedido(int numero, DateTime data, float valor)
        {
            Numero = numero;
            Data = data;
            Valor = valor;
        }
        //Declara o método
        public void gerarNota()
        {
            Console.WriteLine($"Nº Fatura: {Numero}\nData Emissão: {Data}\nValor: {Valor}");
        }

        public void emitirCupom()
        {
            Console.WriteLine($"Cupom fiscal emitido para o pedido {Numero} no valor de {Valor} em {Data}");
        }
        public void inserir()
        {
            //Adiciona pedido na lista
            listaPedidos.Add(this);
            Console.WriteLine($"Pedido {Numero} inserido na lista de pedidos.");
        }
        public void atualizar()
        {
            // Encontra o pedido na lista com base no número
            Pedido pedidoExistente = listaPedidos.Find(x => x.Numero == Numero);
            if (pedidoExistente != null)
            {
                //Atualiza dados do pedido
                pedidoExistente.Data = Data;
                pedidoExistente.Valor = Valor;
            }
            else Console.WriteLine("Pedido não encontrado.");
        }

        public void apagar()
        {
            //Procura pelo pedido e se ele existir, remove
            Pedido pedidoExistente = listaPedidos.Find(x => x.Numero == Numero);
            if (pedidoExistente != null)
            {
                listaPedidos.Remove(pedidoExistente);
            }
            else Console.WriteLine("Nada encontrado para eliminar");
        }
        public void procurar()
        {
            //Verifica a existencia do pedido
            Pedido pedidoExistente = listaPedidos.Find(x => x.Numero == Numero);
            if (pedidoExistente != null)
            {
                Console.WriteLine($"Pedido >{Numero}< encontrado: Data - {pedidoExistente.Data}, Valor - {pedidoExistente.Valor}");
            }
            else
            {
                Console.WriteLine($"Pedido {Numero} não encontrado.");
            }
        }
    }
}
