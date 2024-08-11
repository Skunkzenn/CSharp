
using Ex5_Abstract;

List<Funcionario> listFuncionarios = new List<Funcionario>();

listFuncionarios.Add(new Gestor(1, "Joaquim", 800.00, 500));
listFuncionarios.Add(new FuncFullTime(2, "Kusk", 0.00, 80, 35.00, 45.00));
listFuncionarios.Add(new FuncPartTime(3, "Afred", 0.00, 25, 28.00));

foreach (Funcionario func in listFuncionarios)
{
    if (func is Gestor gestor) {
        gestor.CalcularSalario();
        Console.WriteLine("Gestor" + func);
    }
    else if (func is FuncFullTime fullTime)
    {
        fullTime.CalcularSalario();
        Console.WriteLine("FT" + func);
    }
    else if (func is FuncPartTime partTime)
    {
        partTime.CalcularSalario();
        Console.WriteLine("PT" + func);
    }
}
Console.WriteLine();