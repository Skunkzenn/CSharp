using System.Globalization;
namespace System
{
    //Classe estática
    static class DateTimeExtensions
    {                                   //Aqui dentro determina que o método de extensão é do tipo DateTime
        public static string ElapsedTime(this DateTime thisObj)
        {
            //Lógica para transformar a data em duração(horas), lembrar que a data/hora está a ser comparada com data/hora atual do PC
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}