namespace Exercicio_ClassesMetodosAbstratos.Entities
{
    class Individual : TaxPayer
    {
        public double GastosSaude { get; set; }
        public Individual(string nome, double rendaAnual, double gastosSaude):base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalculoImposto()
        {
            if (RendaAnual < 20000)
            {
                return 0.15 * RendaAnual - GastosSaude * 0.50;
            }
            else
            {
                return 0.25 * RendaAnual - GastosSaude * 0.50;
            }
        }
    }
}
