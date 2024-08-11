namespace MetodosAbstratos.Entities
{
    class JuridicPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public JuridicPerson(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public sealed override double TotalTax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
