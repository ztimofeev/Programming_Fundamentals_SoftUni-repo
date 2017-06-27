using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingValidation_II_Version
{
    public class ParkingValidation
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, string> carPark = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Split().ToArray();
                var command = inputData[0];
                var userName = inputData[1];

                switch (command)
                {
                    case "register":
                        var licensePlate = inputData[2];
                        PrintInput(Register(carPark, userName, licensePlate));
                        break;

                    case "unregister":
                        PrintInput(Unregister(carPark, userName));
                        break;
                }
            }

            foreach (KeyValuePair<string, string> kvp in carPark)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }

        private static string Unregister(Dictionary<string, string> carPark, string userName)
        {
            if (! carPark.ContainsKey(userName))
            {
                return String.Format($"ERROR: user {userName} not found");
            }
            carPark.Remove(userName);
            return String.Format($"user {userName} unregistered successfully");
        }

        private static string Register(Dictionary<string, string> carPark, string userName, string licensePlate)
        {
            if (carPark.ContainsKey(userName))
            {
                return String.Format($"ERROR: already registered with plate number {carPark[userName]}");
            }

            if (!ValidateLicensePlate(licensePlate))
            {
                return String.Format($"ERROR: invalid license plate {licensePlate}");
            }

            if (carPark.ContainsValue(licensePlate))
            {
                return String.Format($"ERROR: license plate {licensePlate} is busy");
            }

            carPark.Add(userName, licensePlate);
            return String.Format($"{userName} registered {licensePlate} successfully");
        }

        private static bool ValidateLicensePlate(string licensePlate)
        {
            bool isValidNumbers = licensePlate.ToCharArray()
                .Skip(2)
                .Take(4)
                .All(d => char.IsDigit(d));

            bool isValidLetters = licensePlate.ToCharArray()
                .Take(2)
                .Concat(licensePlate.ToCharArray().Skip(6).Take(2).ToArray())
                .All(l => l >= 'A' && l <= 'Z');

            return licensePlate.Length == 8 && isValidLetters && isValidNumbers;
        }

        private static void PrintInput(string input)
        {
            Console.WriteLine(input);
        }
    }
}
