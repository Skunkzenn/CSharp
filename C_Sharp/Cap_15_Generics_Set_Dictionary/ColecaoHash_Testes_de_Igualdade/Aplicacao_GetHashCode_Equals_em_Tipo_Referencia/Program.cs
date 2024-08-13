using System;
using System.Collections.Generic;
using Course.Entities;
namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			//Instanciação da coleção HashSet da classe product
			HashSet<Product> a = new HashSet<Product>();
			a.Add(new Product("TV", 900.0));
			a.Add(new Product("Notebook", 1200.0));

			//Instanciação da coleção HashSet da classe point
			HashSet<Point> b = new HashSet<Point>();
			b.Add(new Point(3, 4));
			b.Add(new Point(5, 10));

			//Esse produto prod vai ser outro objeto, diferente do conjunto, com endereço de memória diferentes!
			Product prod = new Product("Notebook", 1200.0);

			//Em primeiro momento o resultado será falso, pois o endereço de memória é diferente
			//Mas quando aplicarmos o GetHashCode && Equals na classe Product esse valor já deve constar como verdadeiro
			//Logo estaremos a aplicar as funções para comparar um produto com outro.
			Console.WriteLine(a.Contains(prod)); 


			//Quando o tipo é struct, o compilador vai comparar pelo conteúdo e não por referência
			//Logo todo tipo como int, double, etc... já terá internamente os algoritmos GetHashCode & Equals
			Point point = new Point(5, 10);
			Console.WriteLine(b.Contains(point));
		}
	}
}