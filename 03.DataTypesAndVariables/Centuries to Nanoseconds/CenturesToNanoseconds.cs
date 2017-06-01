namespace Centuries_to_Nanoseconds
{
    using System;

    public class CenturesToNanoseconds
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.242199);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            Decimal milliseconds = seconds * 1000;
            Decimal microseconds = milliseconds * 1000;
            Decimal nanoseconds = microseconds * 1000;

            Console.Write($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
