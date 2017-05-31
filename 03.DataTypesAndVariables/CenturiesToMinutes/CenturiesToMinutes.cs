namespace CenturiesToMinutes
{
    using System;

    public class CenturiesToMinutes
    {
        public static void Main()
        {
            byte century = byte.Parse(Console.ReadLine());

            int years = century * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
