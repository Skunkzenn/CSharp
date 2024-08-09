namespace ExercicioHerancas
{
    class Employee
    {
        public static List<Employee> listEmployees = new List<Employee>();
        public string name { get; set;}
        public int hours { get; set;}
        public double valuePerHour { get; set;}
    
        public Employee(string name, int hours, double valuePerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            double total = 0;
            total += valuePerHour * hours;
            return total;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
