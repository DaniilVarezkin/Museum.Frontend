namespace Museum.Frontend.Infrastructure.Common
{
    public static class DateFormater
    {
        public static string FormatDateRange(DateTime startDate, DateTime endDate)
        {
            if (startDate.Year != endDate.Year)
            {
                return $"{startDate:dd MMMM yyyy} - {endDate:dd MMMM yyyy}";
            }
            else if (startDate.Month != endDate.Month)
            {
                return $"{startDate:dd MMMM} - {endDate:dd MMMM}";
            }
            else
            {
                return $"{startDate:dd}-{endDate:dd MMMM}";
            }
        }
    }
}
