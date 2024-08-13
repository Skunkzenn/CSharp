using Generics_Set_Exercicio.Entities;

namespace Generics_Set_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int numA = int.Parse(Console.ReadLine());
            for (int i = 0; i < numA; i++)
            {
                Console.Write("Id: ");
                int idInsert = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                students.Add(new Student(idInsert, name));
            }

            Console.Write("How many students for course B? ");
            numA = int.Parse(Console.ReadLine());
            for (int i = 0; i < numA; i++)
            {
                Console.Write("Id: ");
                int idInsert = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                students.Add(new Student(idInsert, name));
            }

            Console.Write("How many students for course C? ");
            numA = int.Parse(Console.ReadLine());
            for (int i = 0; i < numA; i++)
            {
                Console.Write("Id: ");
                int idInsert = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                students.Add(new Student(idInsert, name));
            }

            Console.WriteLine(students.Count()); 
        }
    }
}
