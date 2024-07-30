namespace ExercicioHerancas
{
    class OutSourceEmployee : Employee
    {
        public double additionalCharge { get; set; }
        public OutSourceEmployee(string name, int hours, double valuePerHour, double additionalCharge): base(name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + additionalCharge * 1.10;
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
