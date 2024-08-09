namespace IferenciaVar;

class Var
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        string day;
        if (x == 1)
        {
            day = "Sunday";
        }
        else if (x == 2)
        {
            day = "Monday";
        }
        else if (x == 3)
        {
            day = "Tuesday";
        }
        else if (x == 4)
        {
            day = "Wednesday";
        }
        else if (x == 5)
        {
            day = "Thursday";
        }
        else if (x == 6)
        {
            day = "Friday";
        }
        else if (x == 7)
        {
            day = "Saturday";
        }
        else
        {
            day = "Invalid value";
        }
        Console.WriteLine("Day: " + day);
    }
}