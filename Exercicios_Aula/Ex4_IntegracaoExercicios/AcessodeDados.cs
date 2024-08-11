using System.Runtime.Serialization.Formatters.Binary;

namespace Ex4_IntegracaoExercicios
{
    class AcessodeDados
    {
        public static List<Contatos> contatos = new List<Contatos>();

        public AcessodeDados() { }

        public List<Contatos> ObterContatos() { return contatos; }

        public void AdicionarContato(Contatos contato)
        {
            contatos.Add(contato);
        }

        public void SaveContatosService(List<Contatos> contatos, string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, contatos);
                }

                Console.WriteLine($"Contact data saved in {fileName} successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving contact data: {ex.Message}");
            }
        }

        //Método que lê os dados dos animais do ficheiro binário
        public List<Contatos> LoadContatosService(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    List<Contatos> contatosList = formatter.Deserialize(fs) as List<Contatos>;

                    if (contatosList != null && contatosList.Count > 0)
                    {
                        return contatosList;
                    }
                    else
                    {
                        Console.WriteLine("The contact list is empty or the data could not be read.");
                        return null;
                    }
                }
            }
            //Usado para capturar qualquer erro inesperado que possa ocorrer ao tentar ler o arquivo e desserializar os dados.
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading contact data:  {ex.Message}");
                return null;
            }
        }
    }
}
