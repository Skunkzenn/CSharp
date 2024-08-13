/*
	Coleções HASH são coleções, que indexam elementos com base no algoritmo hash(cálculos efetuados pelo computador);
	Outra estrutura muito comum que usa o algoritmo HASH, é o Dictionary (MAP em algumas linguagens)
	Nessas estruturas não temos uma posição para cada elemento, cada elemento é posicionado na estrutura com o calculo do hash, que é gerado com base nos dados do objeto
 */

/* 
 * Como as coleções Hash testam igualdade?
	Se GetHashCode e Equals estiverem implementados: (Por padrão, os tipos: string, int, double... já possuem internamente GetHashCode e Equals implementados.)
		Primeiro GetHashCode. Se der igual, usa Equals para confirmar. 

	Se GetHashCode e Equals NÃO estiverem implementados:
		Tipos referência: compara as referências dos objetos
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