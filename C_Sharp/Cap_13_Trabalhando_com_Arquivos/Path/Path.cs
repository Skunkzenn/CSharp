/* 
 
• Namespace System.IO
• Realiza operações com strings que contém informações de arquivos ou pastas.
• https://msdn.microsoft.com/en-us/library/system.io.path(v=vs.110).aspx

 */


using System.IO;
namespace Cap_13_Trabalhando_c_Arquivos.Using_Block
{
    class Directory_DirectoryInfo
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Programacao PC\source\repos\file1.txt";


            //indica o caracter de separação entre as pastas e sub-pastas
            Console.WriteLine("Directory Separator Char" + Path.DirectorySeparatorChar);

            //ponto e virgula é o caracter utilizado para separar entre paths diferentes
            Console.WriteLine("Path Separator: "+ Path.PathSeparator);

            //irá exibir o conteúdo somente relativo a pasta  
            Console.WriteLine("Get Directory Name: " + Path.GetDirectoryName(path));

            //Exibe nome do arquivo completo
            Console.WriteLine("Get File Name: " + Path.GetFileName(path));

            //Exibe nome do arquivo, sem extensão
            Console.WriteLine("Get File Name Without Extension" + Path.GetFileNameWithoutExtension(path));

            //Exibe o nome da extensão do ficheiro
            Console.WriteLine("Get Extension" + Path.GetExtension(path));

            //Exibe o caminho completo juntamente com o tipo do ficheiro
            Console.WriteLine("Get Full Path: " + Path.GetFullPath(path));

            //Informa qual é a pasta temporária do sistema, na qual podemos manipular dados temporário de aplicações
            Console.WriteLine("Get Temp Path: " + Path.GetTempPath);


        }
    }
}
