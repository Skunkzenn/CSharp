/* 

Fazer um programa para ler o caminho de um arquivo .csv contendo os dados de itens vendidos. 
Cada item possui um nome, preço unitário e quantidade, separados por vírgula. 
Você deve gerar um novo arquivo chamado "summary.csv", localizado em uma subpasta chamada "out" a partir da pasta original do arquivo de origem.
Contendo apenas o nome e o valor total para
aquele item (preço unitário multiplicado pela quantidade),
conforme exemplo.

 */

using Exercicio_Trabalhando_Arquivos.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicita ao utilizador que insira o caminho completo do arquivo
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {   //Lê todas as linhas do arquivo específicado anteriormente, as linhas são armazenadas pelo array lines
                string[] lines = File.ReadAllLines(sourceFilePath);

                //Obtém o caminho do diretório do arquivo
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);

                //Cria uma sub-pasta dentro do caminho obtido anteriormente
                string targetFolderPath = sourceFolderPath + @"\out";

                //Cria o ficheiro dentro da sub-pasta criada anteriormente
                string targetFilePath = targetFolderPath + @"\summary.csv";

                //Responsável por criar o diretório 'targetFolderPath'
                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
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
