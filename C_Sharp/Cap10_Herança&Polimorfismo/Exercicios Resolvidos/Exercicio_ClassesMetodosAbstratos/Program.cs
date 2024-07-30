using Exercicio_ClassesMetodosAbstratos.Entities;
using System.Globalization;

List<TaxPayer> listTaxPayers = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int numOfReg = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfReg; i++)
{
    Console.WriteLine($"Tax payer #{i + 1} data:");
    Console.Write("Individual or company (i/c)? ");
    char selectMode = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (selectMode == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpends = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        listTaxPayers.Add(new Individual(name, anualIncome, healthExpends));
    }
    else if (selectMode == 'c')
    {
        Console.Write("Number of employees: ");
        int numEmployee = int.Parse(Console.ReadLine());
        listTaxPayers.Add(new Company(name, anualIncome, numEmployee));
    }
    else
    {
        Console.WriteLine("Incorrect value.\nClosed.");
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
foreach (TaxPayer taxPayer in listTaxPayers)
{
    Console.WriteLine(taxPayer + "$ " + taxPayer.CalculoImposto().ToString("F2", CultureInfo.InvariantCulture));
}

Console.WriteLine();
Console.Write("TOTAL TAXES: ");
//Cria-se uma variável auxiliar para calcular o somatorio total do imposto listado a ser pago
double totalImpostos = listTaxPayers.Sum(taxPayer => taxPayer.CalculoImposto());
Console.Write(totalImpostos.ToString("F2", CultureInfo.InvariantCulture));
