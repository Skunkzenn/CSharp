namespace IferenciaVar;

class Var
{
    static void Main(string[] args)
    {
        /* 
         • Representa um INSTANTE
         • É um tipo valor (struct)
         https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx
         • Agenda:
         • Representação interna
         • Instanciação: construtores, builders / conversão String -> DateTime
         • Formatação: DateTime -> String
       
        Representação interna:
        • Um objeto DateTime internamente armazena:
        • O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum

        DateTime d1 = DateTime.Now;
        Console.WriteLine(d1);
        Console.WriteLine(d1.Ticks);

        Instanciação: 
        • Construtores
            • DateTime(ano, mes, dia)
            • DateTime(ano, mes, dia, hora, minuto, segundo) [opcional: kind]
            • DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo) [opcional: kind]
        • Builders
            • DateTime.Now
            • DateTime.UtcNow
            • DateTime.Today [time: 00:00:00]
            • DateTime.Parse(string)
            • DateTime.ParseExact(string, string)
        */

        //Demo - construtores
        DateTime d1 = new DateTime(2000, 8, 15);
        DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
        DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);

        //Demo - Now, UtcNow, Today
        DateTime d1 = DateTime.Now;
        DateTime d2 = DateTime.UtcNow;
        DateTime d3 = DateTime.Today;
        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);

        //Demo - Parse
        DateTime d1 = DateTime.Parse("2000-08-15");
        DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
        DateTime d3 = DateTime.Parse("15/08/2000");
        DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);

        //Demo - ParseExact
        DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        Console.WriteLine(d1);
        Console.WriteLine(d2);
    }