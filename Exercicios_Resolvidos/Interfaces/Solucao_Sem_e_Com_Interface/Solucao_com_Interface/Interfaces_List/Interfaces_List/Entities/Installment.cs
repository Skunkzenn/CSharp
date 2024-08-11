using System.Globalization;

namespace Interfaces_List.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return "Installments:\n" //Formatação correta para a tipologia de data a ser inserida
                + DueDate.ToString("dd/MM/yyyy") + 
                " - " 
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
