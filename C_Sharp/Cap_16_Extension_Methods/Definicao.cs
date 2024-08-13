/*
 * 
Extension methods
        • São métodos que estendem a funcionalidade de um tipo(classe, struct), sem precisar alterar o código fonte deste tipo, nem herdar desse tipo
    
    Como fazer um extension method?
        • Criar uma classe estática
        • Na classe, criar um método estático
        • O primeiro parâmetro do método deverá ter o prefixo this, seguido da 
        declaração de um parâmetro do tipo que se deseja estender. Esta será uma 
        referência para o próprio objeto
 */

/* Demo 1
   
Vamos criar um extension method chamado "ElapsedTime()" no struct DateTime para apresentar um objeto DateTime na forma de tempo
decorrido, podendo ser em horas (se menor que 24h) ou em dias caso contrário. 

Por exemplo:
    DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            "4.5 hours"
            "3.2 days"
*/