/*
 * 
Extension methods
        � S�o m�todos que estendem a funcionalidade de um tipo(classe, struct), sem precisar alterar o c�digo fonte deste tipo, nem herdar desse tipo
    
    Como fazer um extension method?
        � Criar uma classe est�tica
        � Na classe, criar um m�todo est�tico
        � O primeiro par�metro do m�todo dever� ter o prefixo this, seguido da 
        declara��o de um par�metro do tipo que se deseja estender. Esta ser� uma 
        refer�ncia para o pr�prio objeto
 */

/* Demo 1
   
Vamos criar um extension method chamado "ElapsedTime()" no struct DateTime para apresentar um objeto DateTime na forma de tempo
decorrido, podendo ser em horas (se menor que 24h) ou em dias caso contr�rio. 

Por exemplo:
    DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            "4.5 hours"
            "3.2 days"
*/