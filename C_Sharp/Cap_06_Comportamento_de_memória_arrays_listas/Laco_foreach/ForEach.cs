/* Laço for each 
 * Sintaxe opcional e simplificada para percorrer coleções. (vetor, listas, outros tipos de estruturas de dados)
 * Leitura: "para cada objeto 'obj' contido em vect, faça:" 
 */

string[] vect = new string[] { "Maria", "Bob", "Alex" };
         //Colocamos o tipo de vetor, no caso string, damos um apelido para cada elemento do vetor 'obj' ou qualquer outro;
         //Ficando: Para cada obj contido no meu vetor... então realiza-se a operação
foreach (string obj in vect)
{
    Console.WriteLine(obj);
}

//Poderíamos fazer dessa forma:
for (int i = 0; i < vect.Length; i++)
{
    Console.Write(vect[i]);
}