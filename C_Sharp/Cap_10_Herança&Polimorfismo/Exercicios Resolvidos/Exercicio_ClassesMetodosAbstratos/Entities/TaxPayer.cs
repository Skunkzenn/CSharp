namespace Exercicio_ClassesMetodosAbstratos.Entities;

abstract class TaxPayer
{
    public string Nome { get; set; }
    public double RendaAnual { get; set; }

    public TaxPayer(string nome, double rendaAnual){
        Nome = nome;
        RendaAnual = rendaAnual;
    }

    public abstract double CalculoImposto();

    public override string ToString()
    {
        return $"{Nome}: ";
    }
}