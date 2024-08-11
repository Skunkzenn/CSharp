namespace MetodosAbstratos.Entities
{
    class PhysicPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public PhysicPerson(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public sealed override double TotalTax()
        {
            if(AnualIncome < 20000.00)
            {   double total = AnualIncome * 0.15;
                if(HealthExpenditures > 0)
                {
                    total -= HealthExpenditures * 0.5;
                }
                return total;
            }
            else
            {
                double total = AnualIncome * 0.25;
                if (HealthExpenditures > 0)
                {
                    total -= HealthExpenditures * 0.5;
                }
                return total;
            }
        }
    }
}
