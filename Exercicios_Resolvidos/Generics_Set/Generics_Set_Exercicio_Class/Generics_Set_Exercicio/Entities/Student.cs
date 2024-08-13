namespace Generics_Set_Exercicio.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student)) return false;
            Student other = (Student)obj; // Assim,se for gerado erro, vai ser possível tratar a excessão
            //Student other2 = other as Student; Dessa forma ele apenas vai retornar null se der error
            return Id.Equals(other.Id);
        }
    }
}
