namespace CountWorkingDays
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class CountWorkingDays
    {
        public static void Main()
        {
            var inputStartDate = Console.ReadLine();
            var inputEndDate = Console.ReadLine();

            DateTime startDay = DateTime.ParseExact(inputStartDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime endDay = DateTime.ParseExact(inputEndDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            int counter = 0;

            for (var date = startDay; date <= endDay; date = date.AddDays(1))
            {
                var currentYear = date.Year;

                DateTime[] holidays = new DateTime[]
                {
                new DateTime(currentYear, 1, 1),
                new DateTime(currentYear, 3, 3),
                new DateTime(currentYear, 5, 1),
                new DateTime(currentYear, 5, 6),
                new DateTime(currentYear, 5, 24),
                new DateTime(currentYear, 9, 6),
                new DateTime(currentYear, 9, 22),
                new DateTime(currentYear, 11, 1),
                new DateTime(currentYear, 12, 24),
                new DateTime(currentYear, 12, 25),
                new DateTime(currentYear, 12, 26)
                };

                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(date))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
