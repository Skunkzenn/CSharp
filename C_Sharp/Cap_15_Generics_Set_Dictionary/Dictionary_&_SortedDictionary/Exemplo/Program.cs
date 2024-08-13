using System;
using System.Collections.Generic;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar os tipos par�metrizados, qual � o tipo da chave & qual o tipo do valor
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";//O valor correspondente a chave fone, como est� a ser subscrita no passo a seguir, o �ltimo valor � o que prevalece
            cookies["phone"] = "99771133";

            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");
            //Console.WriteLine(cookies["email"]); //Ocorrer� erro de exception, pois a chave key n�o existe mais

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

            //Impress�o do DICTIONARY
            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
