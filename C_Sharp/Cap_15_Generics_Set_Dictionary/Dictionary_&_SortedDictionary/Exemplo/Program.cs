using System;
using System.Collections.Generic;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar os tipos parâmetrizados, qual é o tipo da chave & qual o tipo do valor
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";//O valor correspondente a chave fone, como está a ser subscrita no passo a seguir, o último valor é o que prevalece
            cookies["phone"] = "99771133";

            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");
            //Console.WriteLine(cookies["email"]); //Ocorrerá erro de exception, pois a chave key não existe mais

            Console.WriteLine("Phone number: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }
            Console.WriteLine("Size: " + cookies.Count);

            //Impressão do DICTIONARY
            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
