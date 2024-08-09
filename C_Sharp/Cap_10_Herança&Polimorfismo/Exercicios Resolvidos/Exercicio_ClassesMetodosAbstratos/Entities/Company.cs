namespace Exercicio_ClassesMetodosAbstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumDeFuncionarios { get; set; }
        public Company(string nome, double rendaAnual, int numDeFuncionarios):base(nome, rendaAnual)
        {
            NumDeFuncionarios = numDeFuncionarios;
        }
        public override double CalculoImposto()
        {
            if (NumDeFuncionarios > 10)
            {
                return 0.14 * RendaAnual;
            }
            else
            {
                return 0.16 * RendaAnual;
            }
        }
    }
}
