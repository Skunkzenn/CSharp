using System.Linq;

namespace Dictionary_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>(); 

            Console.Write("Enter location file:");
            string locFile = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(locFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        //Ter atenção a essa lógica, logo se eu tenho no meu dicionario a mesma Key, então
                        //se o meu objetivo é somar os votos, logo atribuo essa condição, verificando se a key já existe
                        if (dictionary.ContainsKey(name))
                        {
                            dictionary[name] += votes;
                        }
                        else
                        {
                            dictionary.Add(name, votes);
                        }
                    }
                    foreach (KeyValuePair<string, int> pair in dictionary)
                    {
                        //Como já foi somado os valores dos votos, logo podemos imprimir
                        Console.WriteLine(pair.Key + ", " + pair.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
