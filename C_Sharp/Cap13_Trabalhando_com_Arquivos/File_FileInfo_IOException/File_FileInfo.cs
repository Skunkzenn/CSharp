/*  

File e FileInfo são duas classes básicas que pertencem ao namespace System.IO
 
 *  Realizam operações com arquivos (create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStream.

FileStream é um objeto que encapsula a sequência de leitura ou escrita em um recurso de entrada e saída, no caso um arquivo;

File: 
    É mais simples, ela simplesmente disponibiliza operações estatísticas pra gente. 
    Então você não vai precisar instancia um objeto pra depois você chamar essas operações.
    Elas serão estaticas, então conseguimos chamar, colocando a palavra File.'Operação'; 
    Realiza uma verificação de segurança para cada operação que você chamar, então ela é mais lenta que a FileInfo. 

FileInfo:
    Temos que instancias o objeto e chamar as operações a partir dele, sendo esse objeto, já atrelado a aquele arquivo que você abrir e o sistema operacional vai ser avisado disso.
    Então, as operações de segurança, não precisam de ser realizadas a cada operação que você chamar, logo o processo será mais rápido. 

Quando usar o File ou FileInfo?
Quando for um programa simples, utilizamos o FILE, por termos que só fazer uma operação básica, não teríamos problemas com a perda de perfomance.
Porém, se for um programa mais complexo, com muitas operações e onde a performance seja importante, nós vamos utilizar o FILEINFO.


IOException

* Pertence ao namespace System.IO
Ela é a superclasse de todas a excessões possíveis que possam acontecer, quando trabalhamos com arquivos:

• DirectoryNotFoundException
• DriveNotFoundException
• EndOfStreamException
• FileLoadException
• FileNotFoundException
• PathTooLongException
• PipeException

*/

using System.IO;

string sourcePath = @"C:\Users\Programacao PC\source\repos\file1.txt";
string targetPath = @"C:\Users\Programacao PC\source\repos\file2.txt";

try
{   //instancia objeto recebendo a string
    FileInfo fileInfo = new FileInfo(sourcePath);
    //o objeto que recebeu a instancia, faz uma cópia do arquivo para o targetPath
    fileInfo.CopyTo(targetPath);

    //vai ler todas as linhas do arquivo e guardar todas as linhas, como elemento do vetor
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}