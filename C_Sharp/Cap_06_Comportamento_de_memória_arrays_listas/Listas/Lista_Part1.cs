/* 
 
Listas
• Lista é uma estrutura de dados:
• Homogênea (dados do mesmo tipo)
• Ordenada (elementos acessados por meio de posições)
• Inicia vazia, e seus elementos são alocados sob demanda
• Cada elemento ocupa um "nó" (ou nodo) da lista
• Classe: List
• Namespace: System.Collections.Generic

• Vantagens:
• Tamanho variável
• Facilidade para se realizar inserções e deleções

• Desvantagens:
• Acesso sequencial aos elementos (Como as listas sao encadeanas, signifca que temos uma lista de 500mil elementos, e querer encontrar o 250mil vamos ter que percorrer nodo por nodo ate encontrar o elemento

 */

using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {   //Declara o tipo da lista
                                //Instancia a lista
            List<string> list = new List<string>();
            //Depois que a lista já estiver instanciada, é que vamos adicionar elementos a ela

            //A linguagem em C# permite você criar uma lista, instanciar e já adicionar elementos a ela

            List<string> list2 = new List<string> { "Victor", "Eliane", "Mae" };
        
        }
    }
}