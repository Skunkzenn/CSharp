using System;
using System.Collections.Generic;
using Course.Entities;
namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			//Instancia��o da cole��o HashSet da classe product
			HashSet<Product> a = new HashSet<Product>();
			a.Add(new Product("TV", 900.0));
			a.Add(new Product("Notebook", 1200.0));

			//Instancia��o da cole��o HashSet da classe point
			HashSet<Point> b = new HashSet<Point>();
			b.Add(new Point(3, 4));
			b.Add(new Point(5, 10));

			//Esse produto prod vai ser outro objeto, diferente do conjunto, com endere�o de mem�ria diferentes!
			Product prod = new Product("Notebook", 1200.0);

			//Em primeiro momento o resultado ser� falso, pois o endere�o de mem�ria � diferente
			//Mas quando aplicarmos o GetHashCode && Equals na classe Product esse valor j� deve constar como verdadeiro
			//Logo estaremos a aplicar as fun��es para comparar um produto com outro.
			Console.WriteLine(a.Contains(prod)); 


			//Quando o tipo � struct, o compilador vai comparar pelo conte�do e n�o por refer�ncia
			//Logo todo tipo como int, double, etc... j� ter� internamente os algoritmos GetHashCode & Equals
			Point point = new Point(5, 10);
			Console.WriteLine(b.Contains(point));
		}
	}
}