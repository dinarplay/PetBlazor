namespace PetBlazor.Services
{
    public class AgeCalculateService
    {
        public string GetAge(DateOnly dateOnly)
        {
            int year  = DateTime.Now.Year - dateOnly.Year;
            int month = Math.Abs(DateTime.Now.Month - dateOnly.Month);
            int day =  Math.Abs(DateTime.Now.Day - dateOnly.Day);
            if (DateTime.Now.Month <= month)
            {
                year--;
                month = 12 - month;
            }
            if (DateTime.Now.Day < dateOnly.Day)
            {
                month--;
                day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - (dateOnly.Day - DateTime.Now.Day);
            }
            return $"Вам {year} год(а), {month} месяца(ев), {day} день(я)";
        }
    }
}
