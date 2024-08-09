namespace Projetos_CSharp;

/* Leia 2 valores inteiros (A e B). 
 * Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos"
 * Indicando se os valores lidos são múltiplos entre si. 
 * Atenção: os números devem poder ser digitados em ordem crescente ou decrescente. */

internal class Multiplo_Or_No
{
    static void Main(string[] args) {

        string[] vetores = Console.ReadLine().Split(' ');
        int a = int.Parse(vetores[0]);
        int b = int.Parse(vetores[1]);

        bool resultado = a % b == 0 || b % a == 0;

        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        Console.WriteLine($"Resultado: {resultado}");

        if (resultado) Console.WriteLine("É múltiplo");
        else Console.WriteLine("Não é múltiplo");
    }
}