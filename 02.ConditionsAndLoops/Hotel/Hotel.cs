namespace Hotel
{
    using System;

    public class Hotel
    {
        public static void Main()
        {
            var month = Console.ReadLine().ToLower();
            var countNights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            if (month == "may" || month == "october")
            {
                priceDouble = 65.00;
                priceSuite = 75.00;

                if (countNights > 7)
                {
                    priceStudio = 50.00 * 0.95;
                }
                else
                {
                    priceStudio = 50.00;
                }
            }
            else if (month == "june" || month == "september")
            {
                priceStudio = 60.00;
                priceSuite = 82.00;

                if (countNights > 14)
                {
                    priceDouble = 72.00 * 0.90;
                }
                else
                {
                    priceDouble = 72.00;
                }
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                priceStudio = 68.00;
                priceDouble = 77.00;

                if (countNights > 14)
                {
                    priceSuite = 89.00 * 0.85;
                }
                else
                {
                    priceSuite = 89.00;
                }
            }

            var totalStudioPrice = countNights * priceStudio;
            var totalDoublePrice = countNights * priceDouble;
            var totalSuitePrice = countNights * priceSuite;

            if ((month == "september" || month == "october") && countNights > 7)
            {
                totalStudioPrice -= priceStudio;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
        }
    }
}
