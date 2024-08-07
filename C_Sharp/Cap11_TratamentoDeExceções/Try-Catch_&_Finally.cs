/* 

Exceções

• Uma exceção é qualquer condição de erro ou comportamento
inesperado encontrado por um programa em execução
• No .NET, uma exceção é um objeto herdado da classe
System.Exception
• Quando lançada, uma exceção é propagada na pilha de chamadas de
métodos em execução, até que seja capturada (tratada) ou o
programa seja encerrado

Por que exceções?
• O modelo de tratamento de exceções permite que erros sejam tratados de forma consistente e flexível, usando boas práticas

 Vantagens:
• Delega a lógica do erro para a classe / método responsável por conhecer as
regras que podem ocasionar o erro
• Trata de forma organizada (inclusive hierárquica) exceções de tipos diferentes
• A exceção pode carregar dados quaisquer

*/

/*

Estrutura try-catch
• Bloco try
• Contém o código que representa a execução normal do trecho de código que pode acarretar em uma exceção
• Bloco catch
• Contém o código a ser executado caso uma exceção ocorra
• Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido)

Sintaxe
using System;
try
{
}      //tipo de exceção 
catch (ExceptionType e)
{
}      //tipo de exceção 
catch (ExceptionType e)
{
}      //tipo de exceção   
catch (ExceptionType e)
{
}

*/

//Exemplo
using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}

/*

Bloco finally

• É um bloco que contém código a ser executado independentemente de ter
ocorrido ou não uma exceção.
• Exemplo clássico: fechar um arquivo ou conexão de banco de dados ao final do
processamento.

Sintaxe:
try {
}
catch (ExceptionType e) {
}
finally {
}
*/

//Exemplo
using System;
using System.IO;
public class ProcessFile
{
    public static void Main()
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (fs != null)
            {
                fs.Close();
            }
        }
    }
}