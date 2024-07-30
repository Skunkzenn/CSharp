/* 
 
Essas duas classes, servem para nos oferecer operações com pasta!

• Namespace System.IO
• Operações com pastas (create, enumerate, get files, etc.).

• Directory
• static members (simple, but performs security check for each operation)
• https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx

• DirectoryInfo
• instance members
• https://msdn.microsoft.com/en-us/library/system.io.directoryinfo(v=vs.110).aspx


Segue a mesma lógica do File & FileInfo, lembrar!!

• 1) Vamos listar as pastas a partir de uma pasta informada
• 2) Vamos listar os arquivos a partir de uma pasta informada
• 3) Vamos criar uma pasta

 */

//Se quiser utilizar o DirectoryInfo, basta instanciar o objeto de forma análoga, como no FileInfo;


using System.IO;
namespace Cap_13_Trabalhando_c_Arquivos.Using_Block
{
    class Directory_DirectoryInfo
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Programacao PC\source\repos\TestFolder";

            try //1)
            {                                                               //vai listar todas as sub-pastas a partir do 'path'                                     
                                                                                 //Padrão de busca, qualquer nome de arquivo . qualquer extensão
                                                                                       //Chamaro tipo enumerado, todos os diretorios (vai listar inclusive as sub-pastas)
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // O resultado, será uma coleção de strings, correspondentes a basta, do tipo 'IEnumerable'
                Console.WriteLine("FOLDERS: ");
                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }
                
                //2)
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                //3) Basta acompanhar com o caminho da pasta onde quer que seja criada + o nome da pasta
                Directory.CreateDirectory(path + @"\newFolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
