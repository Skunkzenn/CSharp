using System;

/* Palavra this
• É uma referência para o próprio objeto.

Usos comuns:

• Diferenciar atributos de variáveis locais (Java)
• Referenciar outro construtor em um construtor!!
• Passar o próprio objeto como argumento na chamada de um método ou construtor 

 Basicamente sua função será: Diferenciar atributos de variáveis locais */


namespace AutoPropriedades_
{
    class AutoPropriedades
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public AutoPropriedades(string Nome, double Preco)
        {   //Faz a referência do atributo da classe
            this.Nome = Nome; //Sem o this o compilador vai priorizar a variável local.
            this.Preco = Preco;
            Quantidade = 0;
        }

        public AutoPropriedades()
        {
            Quantidade = 0;
        }

        //Referenciar outro construtor em um construtor
        //Pex: Aproveitar o construtor anterior que possuí o valor da quantidade no construtor seguinte, sem ter que repetir novamente o Quantidade = 0
                                                    //Basta usar como abaixo, passando o this(), onde () é referente a nosso construtor padrão;
        public AutoPropriedades(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        //Ao invés de passarmos todos os parâmetros novamente, podemos reaproveitar o construtor de cima, passando corretamente os parâmetros de entrada;
        public AutoPropriedades(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        //Passar o próprio objeto como argumento nachamada de um método ou construtor
        /* 
         class ChessMath {
        //chamando um metodo, passando o proprio objeto da partida de xadrex como argumento
         PlaceNewPiece('e', new King(board, Color.White, this));
        }
         */
    }
}
