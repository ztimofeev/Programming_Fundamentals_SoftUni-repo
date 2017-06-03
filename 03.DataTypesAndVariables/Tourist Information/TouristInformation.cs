namespace Tourist_Information
{
    using System;

    public class TouristInformation
    {
        public static void Main()
        {
            string imperialUnits = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double convertedQuantity = 0;
            string mesure = String.Empty;

            switch (imperialUnits) 
            {
                case "miles":
                    convertedQuantity = quantity * 1.6;
                    mesure = "kilometers";
                    break;
                case "inches":
                    convertedQuantity = quantity * 2.54;
                    mesure = "centimeters";
                    break;
                case "feet":
                    convertedQuantity = quantity * 30;
                    mesure = "centimeters";
                    break;
                case "yards":
                    convertedQuantity = quantity * 0.91;
                    mesure = "meters";
                    break;
                case "gallons":
                    convertedQuantity = quantity * 3.8;
                    mesure = "liters";
                    break;
            }

            Console.WriteLine($"{quantity} {imperialUnits} = {convertedQuantity:f2} {mesure}");
        }
    }
}
