/* 

Sintaxe simplificada que garante que os objetos IDisposable serão fechados.
Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser manualmente fechados.
Exemplos: Font, FileStream, StreamReader, StreamWriter

 */

using System.IO;
namespace Cap_13_Trabalhando_c_Arquivos
{
    class Using_Block
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Programacao PC\source\repos\file1.txt";

            try
            {   //Exemplo dos dois blocos FileStream e StreamReader
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    //Tudo que for executado dentro deste bloco, será executado e terminado quando chegar ao fim
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        //Tudo que for executado dentro deste bloco, será executado e terminado quando chegar ao fim
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }

                //OU USAR UM OU USAR OUTRO
                
                //Apenas o StreamReader utilizando o file para abrir o arquivo, com o código mais limpo.
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
