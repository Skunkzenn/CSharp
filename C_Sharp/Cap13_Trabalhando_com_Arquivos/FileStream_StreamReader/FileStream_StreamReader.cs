/* 
 
- FileStream é uma classe que disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita.
Ela encapsula a associação de um objeto a um recurso de entrada e saída, no caso um arquivo.
Podemos associar um objeto ao FileStream a fim de que ele fique associado a um arquivo e a partir do objeto podemos fazer entrada e saída.

Suporte a dados binários.

Instanciação: 
º Vários constrututores
º File / FileInfo

- StreamReader (Transmissão de dados em sequência)
É um objeto que vamos instanciar, a partir do FileStream, é uma stream capaz de ler caracteres a partir de uma stream binária (ex: FileStream).

Suporte a dados no formato de texto.

Instanciação:
• Vários construtores
• File / FileInfo
 
Ambos utilizam a lib System.IO;

 */

using System.IO;

namespace Course;
class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\Programacao PC\source\repos\file1.txt";
        FileStream fs = null;
        StreamReader sr = null;
        StreamReader sr1 = null;
        try
        {                   //caminho do arquivo e modo de como vamos instanciar o filestream(para ler? para escrever? para ler e escrever?)
                            // para abrir o arquivo e inserir dados no final dele, usariamos o Append,
                            // recriar o arquivo, seria o Create...
            fs = new FileStream(path, FileMode.Open);
            //instância o StreamReader com base no FileStream
            sr = new StreamReader(fs);

            //Ou podemos usar a classe File/FileInfo para instanciar o StreamReader
                       //O OpenText ele implicitamente, instancia o filestream e o streamreader, como se fosse automático, bastando colocar o caminho da string dentro dele
            sr1 = File.OpenText(path);


            //Para ler todas as linhas do arquivo, temos que usar a logica do enquanto não chegar no final do arquivo, ele vai lendo...
            while (!sr.EndOfStream)
            {
                //Exemplo de leitura no arquivo, que vai ler uma linha do arquivo
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }


            //Os streams são recursos operacionais, são recursos do próprio sistema operativo, então, temos que fechar as streams, independente se deram certo ou caíram numa excessão.
        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred." + e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }
    }
}