// Arquivo: IOperacoes.cs
namespace Exercicio2_Interface.Entities;

interface IOperacoes
{
    bool InsertElement(object x);
    bool RemoveElement(object x);
    bool UpdateElement(object x);
    List<Conta> SelectElements(Type typeValue, object x);
}
