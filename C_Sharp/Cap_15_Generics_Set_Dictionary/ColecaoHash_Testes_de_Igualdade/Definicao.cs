/*
	Cole��es HASH s�o cole��es, que indexam elementos com base no algoritmo hash(c�lculos efetuados pelo computador);
	Outra estrutura muito comum que usa o algoritmo HASH, � o Dictionary (MAP em algumas linguagens)
	Nessas estruturas n�o temos uma posi��o para cada elemento, cada elemento � posicionado na estrutura com o calculo do hash, que � gerado com base nos dados do objeto
 */

/* 
 * Como as cole��es Hash testam igualdade?
	Se GetHashCode e Equals estiverem implementados: (Por padr�o, os tipos: string, int, double... j� possuem internamente GetHashCode e Equals implementados.)
		Primeiro GetHashCode. Se der igual, usa Equals para confirmar. 

	Se GetHashCode e Equals N�O estiverem implementados:
		Tipos refer�ncia: compara as refer�ncias dos objetos
		Tipos valor: comparar os valores dos atributos
*/


class Program
{
	static void Main(string[] args)
	{
		HashSet<string> set = new HashSet<string>();

		set.Add("Alex");
		set.Add("Maria");

		Console.WriteLine(set.Contains("Maria"));
	}
}