/* 

É uma stream capaz de escrever caracteres a partir de uma stream binária (ex:FileStream).

Suporte a dados no formato de texto.

Instantiation:
• Several constructors
• File / FileInfo
• CreateText(path)
• AppendText(String)

 */

using System.IO;

namespace Cap_13_Trabalhando_c_Arquivos.Using_Block
{
    class Stream_Writer
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Programacao PC\source\repos\file1.txt";
            string targetPath = @"C:\Users\Programacao PC\source\repos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {   //Vai converter todas as linhas para letras maiúculas 
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
