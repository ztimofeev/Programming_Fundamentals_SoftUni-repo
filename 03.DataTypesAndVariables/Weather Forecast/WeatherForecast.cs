namespace Weather_Forecast
{
    using System;

    public class WeatherForecast
    {
        public static void Main()
        {
            var number = Console.ReadLine();

            string weather = String.Empty;

            long num;

            if (long.TryParse(number, out num))
            {
                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    weather = "Sunny";
                }
                else if (num >= int.MinValue && num <= int.MaxValue)
                {
                    weather = "Cloudy";
                }
                else
                {
                    weather = "Windy";
                }
            }
            else
            {
                weather = "Rainy";
            }

            Console.WriteLine(weather);
        }
    }
}
