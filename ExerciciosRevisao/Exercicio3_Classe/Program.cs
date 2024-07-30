using Exercicio3_Class;
using Exercicio3_Classe;

Espetaculo espetaculo = new Espetaculo("Assrole", "A2", DateTime.Now, 500);
espetaculo.MostrarEspetaculo();

Console.WriteLine();

Bilhete bilhete = new Bilhete("Victor", 3);
bilhete.MostrarDetalhes();