using System;
using System.Collections.Generic;

namespace ParkingValidation
{
    public class ParkingValidation
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, string> registredUsers = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Split();
                var action = inputData[0];
                var name = inputData[1];
                
                if (action == "register")
                {
                    var licensePlateNumber = inputData[2];
                    bool isValid = RegPlateValidation(licensePlateNumber);

                    if (registredUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"“ERROR: already registered with plate number {registredUsers[name]}");
                    }
                    else if (!isValid)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }
                    else if (registredUsers.ContainsValue(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                    }
                    else
                    {
                        registredUsers.Add(name, licensePlateNumber);
                        Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                    }
                }
                else
                {
                    if (!registredUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {name} unregistered successfully");
                        registredUsers.Remove(name);
                    }
                }
            }

            foreach (var usersInParking in registredUsers)
            {
                Console.WriteLine($"{usersInParking.Key} => {usersInParking.Value}");
            }
        }

        public static bool RegPlateValidation(string licensePlate)
        {
            var leftLetters = licensePlate.Substring(0, 2);
            var middleNumbers = licensePlate.Substring(2, 4);
            var rightLetters = licensePlate.Substring(6);

            if (licensePlate.Length != 8)
            {
                return false;
            }

            if (leftLetters.ToUpper() != leftLetters || rightLetters.ToUpper() != rightLetters)
            {
                return false;
            }

            if (!CheckLetters(leftLetters, rightLetters))
            {
                return false;
            }

            int num;
            if (!int.TryParse(middleNumbers, out num))
            {
                return false;
            }

            return true;
        }

        public static bool CheckLetters(string leftLetters, string rightLetters)
        {
            string commonString = leftLetters + rightLetters;
            foreach (var token in commonString)
            {
                if (token < 'A' || token > 'Z')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
