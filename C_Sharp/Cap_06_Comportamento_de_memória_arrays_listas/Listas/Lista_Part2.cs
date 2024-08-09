using System;
using System.Collections.Generic;

namespace CSharp.Cap_6_Comportamento_de_memória_arrays_listas.Listas
{
    internal class Lista_Part2
    {
        static void Main(string[] args)
        {   //Instanciar lista
            List<string> lista = new List<string>();

            //se fosse uma lista de produtos
            //lista.Add(new Product()) também funcionaria

            //Adicionar elementos na lista, do tipo da lista que criamos
            //o Add por padrão adiciona ao final da lista
            lista.Add("Vitao");
            lista.Add("Bob Marley");
            lista.Add("Teikirise");

            foreach (string obj in lista) {
                                 //Passar o parâmetro correto 
                Console.WriteLine(obj);
            }


            //Especificar a posição da lista para inserir objeto
            lista.Insert(2, "Marco");

            //Mostrar o tamanho da lista
            Console.WriteLine("List Count: " + lista.Count);

            //Encontrar primeiro ou último elemento da lista que satisfaça um predicado:
            //Predicado é uma função que pega o valor de obj e vai retonar verdadeiro ou falso, conforme a lógica
            
            //Eu quero o obj X tal que X na posição 0, seja igual ao caracter 'A' 
            string s1 = lista.Find(x => x[0] == 'A'); //Seria a mesma coisa que fazer :
                                                      //static bool Test(string s) { return s[0] == 'A'; }
            Console.WriteLine("First 'A': " + s1);

            //Buscar a última ocorrência com 'A'
            string s2 = lista.FindLast(x => x[0] ==  'A');
            Console.WriteLine("Last 'A': " + s2);

            //Encontrar a primeira e a última posição do elemento da lista que satisfaça um predicado
            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //Filtrar lista com base em um predicado
            //Cria-se uma nova lista, que satisfaça o predicado, ex: pegar na lista apenas os nomes com 5 caracteres
            List<string> list2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Remover Elementos da Lista
            lista.Remove("Alex");
            Console.WriteLine("----------------------------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
                        //Remove todos que começam com M 
            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
                        //Remove pela posição do elemento
            lista.RemoveAt(2);
            Console.WriteLine("----------------------------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
                    //Remove os elementos de uma faixa, posição e contagem
                    //A partir da posição 2, quero remover 2 elementos
            lista.RemoveRange(2, 2);
            Console.WriteLine("----------------------------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
