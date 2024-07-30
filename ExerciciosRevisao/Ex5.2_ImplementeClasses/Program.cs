using Ex5._2_ImplementeClasses.Entities;

Pedido pedido1 = new Pedido(55, DateTime.Now , 800.00f);
Pedido pedido2 = new Pedido(10, DateTime.Now, 900.00f);

//Insere pedido
pedido1.inserir();
pedido2.inserir();

//Atualiza pedido
Pedido pedidoAtualizado = new Pedido (55, DateTime.Now, 8000.00f);
pedidoAtualizado.atualizar();

//Apaga pedido
pedidoAtualizado.apagar();

//Procura pedido
pedido2.procurar();

//Gerar Nota
pedido2.gerarNota();

//Emitir cupom
pedido2.emitirCupom();


//Testes clientes
Cliente cliente1 = new Cliente(01, "Victor", "961723874", "286706695");
Cliente cliente2 = new Cliente(02, "Marcos", "993662555", "265333091");
cliente1.inserir();
cliente2.inserir();

Cliente clienteAtualizado = new Cliente(02, "Jubileu", "55555555", "123456789");
clienteAtualizado.atualizar();
//cliente1.apagar();
cliente2.procurar();