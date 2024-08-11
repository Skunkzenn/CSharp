using Ex5_ImplementeClasses;

Produto produto = new Produto();
produto.setNome("WD 40 500ml");
Console.WriteLine("Produto: " + produto.getNome());

Perfume perfume = new Perfume();
perfume.setNome("Boticario");
perfume.setLote("50B5AD4");
Console.WriteLine($"Perfume: {perfume.getNome()} ||| Lote: {perfume.getLote()}");

Medicamento medicamento = new Medicamento();
medicamento.setNome("Trambolona");
medicamento.setLote(123654);
Console.WriteLine($"Medicamento: {medicamento.getNome()} ||| Lote: {medicamento.getLote()}");

MedicamentoGenerico medicamentoGenerico = new MedicamentoGenerico();
medicamentoGenerico.setNome("Trambolona");
medicamentoGenerico.setLote(12365);
medicamentoGenerico.setDci("Tranabol");
Console.WriteLine($"Nome: {medicamentoGenerico.getNome()} | Lote: {medicamentoGenerico.getLote()} | Nome Genérico: {medicamentoGenerico.getDci()}");