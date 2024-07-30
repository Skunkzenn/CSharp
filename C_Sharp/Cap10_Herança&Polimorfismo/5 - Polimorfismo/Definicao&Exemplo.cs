/*
Polimorfismo
Em Programação Orientada a Objetos o Polimorfismo é:

Recurso que permite que variáveis de um mesmo tipo mais genérico possam apontar para objetos de tipos específicos diferentes, tendo assim comportamentos diferentes conforme cada tipo específico.
    
    //Duas variáveis do tipo account, sendo instânciadas com objetos diferentes, esse comportamente diferente, é o polimorfismo.
    Account acc1 = new Account(1001, "Alex", 500.0);
    Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

    acc1.Withdraw(10.0);
    acc2.Withdraw(10.0);

    Console.WriteLine(acc1.Balance);
    Console.WriteLine(acc2.Balance);

Polimorfismo nada mais é que variáveis do mesmo tipo, sendo instânciada com diferentes tipos de objetos, tendo comportamentos diferentes;

• A associação do tipo específico com o tipo genérico é feita em tempo de execução (upcasting).
• O compilador não sabe para qual tipo específico a chamada do método Withdraw está sendo feita (ele só sabe que são duas variáveis tipo Account):

    Account acc1 = new Account(1001, "Alex", 500.0);
    Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
    acc1.Withdraw(10.0);
    acc2.Withdraw(10.0);

*/