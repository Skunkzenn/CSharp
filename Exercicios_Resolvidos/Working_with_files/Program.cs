using System.IO;
using System.Globalization;
using Working_with_files.Entities;


namespace Working_with_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a directory and file name: ");
            string path = Console.ReadLine();

            try
            {
                //1º) Ler linhas do arquivo
                string[] lines = File.ReadAllLines(path);

                //2º) Busar nome do diretório
                string directory = Path.GetDirectoryName(path);

                //3º) Definir sub-diretório "out" dentro do diretório
                string subDirectory = directory + @"\out";

                //4º) Criar ficheiro "summary.csv" no diretório "out"
                string targetPath = subDirectory + @"\summary.csv";

                //5º) Criar diretório "out"
                Directory.CreateDirectory(subDirectory);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
