namespace DayOfWeek
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main()
        {
            var dateAsString = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateAsString,"d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
