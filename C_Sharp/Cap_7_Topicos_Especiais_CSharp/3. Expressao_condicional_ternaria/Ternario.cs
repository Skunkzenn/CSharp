namespace IferenciaVar;

class Var
{
    static void Main(string[] args)
    {
        /* 
         Expressão condicional ternária é uma estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma condição.
          
        Sintaxe:
          ( condição ) ? valor_se_verdadeiro : valor_se_falso

          
          Exemplos:
          ( 2 > 4 ) ? 50 : 80 R: 80
          ( 10 != 3 ) ? "Maria" : "Alex" R: "Maria"
        */

        //ex if else
        double preco = 34.5;
        double desconto;
        if (preco < 20.0)
        {
            desconto = preco * 0.1;
        }
        else
        {
        }

        //ex ternario
        double preco = 34.5;
        double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
    }