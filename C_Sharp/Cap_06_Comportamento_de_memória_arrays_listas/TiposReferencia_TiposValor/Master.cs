using System.Drawing;

namespace Exercicios_C_.TiposReferencia_TiposValor

{
    class Master
    {
        static void Main(string[] args)
        {
            /* 
             Classes são tipo referência.
                Quando fazemos:
                Product p1, p2; //Estamos criando duas variáveis na área de memória chamada Stack, e essas var não serão as "caixas do produto" ainda, esssa "caixas" só seriam criadas se passássemos: 
                p1 = new Product("TV", 900.00, 0);  
                Agora sim, na área de memória chamada Heap, essas caixinhas serão criadas, sendo que o objeto terá um endereço de memória. 
                A área do Stack funciona como um endereço de memória para esses valores. 
                Seria como ter um endereço na variável p1, indicando onde está o objeto. É uma referência para o objeto.

                Quando você faz: p2 = p1; é uma variável referência, ou seja, você vai estar copiando o endereço de memória da var p1 e consequentemente, buscando os mesmo atributos da classe. 
                Apontando para o mesmo objeto. Por isso que falamos que classes, são tipo REFERÊNCIA.

                Os tipos referência, aceitam valor null, indicando que a var não aponta para ninguém.

                Product p1, p2;

                p1 = new Product("TV", 900.00, 0);
                p2 = null; //Significa que o valor da var p2 vai ser nulo, vazio, como pardão, 0. Indicando que ela não aponta para ninguém.

            Structs são tipo valor:

            A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e NÃO PONTEIROS!!

            Quando fazemos:

            double x, y;

            x = 10; // O valor 10 vai ficar dentro da caixinha
            y = x; //não estamos fazendo uma operação de ponteiros, aqui realmente estamos fazendo um cópia, y vai receber uma cópia de x

             */
            Point p;
            //Embora o point p seja do tipo struct, ele não deixará imprimir enquando a var não foi inicializada.
            Console.WriteLine(p); // erro: variável não atribuída
            
            //Aqui sem o computador vai entender que a var foi inicializada
            //A simples declaração deles aqui, vai criar nas caixinhas, no Stack da memória o valor de X e Y, assim podemos usar normalmente
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            //Entrentando o tipo struct aceita a função new, inicializando seus valores como 0
            ////Isso significa que o tipo struct temos sempre que inicializar
            p = new Point();
            Console.WriteLine(p);
        }

        /*
         Valores padrão
        Quando alocamos (new) qualquer tipo estruturado (classe, struct, array), são atribuídos valores padrão aos seus elementos:
        • números: 0
        • bool: False
        • char: caractere código 0
        • objeto: null

        • Lembrando: uma variável apenas declarada, mas não instanciada, inicia em estado "não atribuída", 
        e o próprio compilador não permite que ela seja acessada.
        */
    }
}
