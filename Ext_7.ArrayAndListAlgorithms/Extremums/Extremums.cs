using System;
using System.Collections.Generic;
using System.Linq;

namespace Extremums
{
    public class Extremums
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split();
            var command = Console.ReadLine();

            if (command == "Min")
            {
                List<int> listOfMinValues = GetMinValuesOfTheElements(sequence);
                Console.WriteLine(string.Join(", ", listOfMinValues));
                Console.WriteLine(listOfMinValues.Sum());
            }
            else if (command == "Max")
            {
                var listOfMaxValues = GetMaxValuesOfTheElements(sequence);
                Console.WriteLine(string.Join(", ", listOfMaxValues));
                Console.WriteLine(listOfMaxValues.Sum());
            }
        }

        public static List<int> GetMaxValuesOfTheElements(string[] sequence)
        {
            List<int> listOfMaxValues = new List<int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                var maxFormOfTheElement = RotateDigitsToMaxValue(sequence[i]);
                listOfMaxValues.Add(maxFormOfTheElement);
            }
            return listOfMaxValues;
        }

        public  static int RotateDigitsToMaxValue(string numberAsString)
        {
            var number = int.Parse(numberAsString);
            var maxNumberVersion = number;
            List<int> listOfNumbersDigits = GetListOfDigits(number);

            if (listOfNumbersDigits.Count > 2)
            {

                for (int j = 0; j < listOfNumbersDigits.Count; j++)
                {
                    var currentRotatedNumber = RotateNumber(listOfNumbersDigits);
                    currentRotatedNumber = int.Parse(string.Join("", listOfNumbersDigits));

                    if (currentRotatedNumber > maxNumberVersion)
                    {
                        maxNumberVersion = currentRotatedNumber;
                    }
                }
            }
            else
            {
                listOfNumbersDigits.Reverse();
                var currentRotatedNumber = int.Parse(string.Join("", listOfNumbersDigits));
                if (currentRotatedNumber > maxNumberVersion)
                {
                    maxNumberVersion = currentRotatedNumber;
                }
            }

            return maxNumberVersion;
        }

        public static List<int> GetMinValuesOfTheElements(string[] sequence)
        {
            List<int> listOfMinValues = new List<int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                var minFormOfTheElement = RotateDigitsToMinValue(sequence[i]);
                listOfMinValues.Add(minFormOfTheElement);
            }
            return listOfMinValues;
        }

        public static int RotateDigitsToMinValue(string numberAsString)
        {
            var number = int.Parse(numberAsString);
            var minNumberVersion = number;
            List<int> listOfNumbersDigits = GetListOfDigits(number);

            if (listOfNumbersDigits.Count > 2)
            {
                for (int j = 0; j < listOfNumbersDigits.Count; j++)
                {
                    var currentRotatedNumber = RotateNumber(listOfNumbersDigits);
                    if (currentRotatedNumber < minNumberVersion)
                    {
                        minNumberVersion = currentRotatedNumber;
                    }
                }
            }
            else
            {
                listOfNumbersDigits.Reverse();
                var currentRotatedNumber = int.Parse(string.Join("", listOfNumbersDigits));
                if (currentRotatedNumber < minNumberVersion)
                {
                    minNumberVersion = currentRotatedNumber;
                }
            }
            
            return minNumberVersion;
        }

        public static List<int> GetListOfDigits(int number)
        {
            List<int> result = new List<int>();

            while (number > 0)
            {
                var lastDigit = number % 10;
                number = number / 10;
                result.Add(lastDigit);
            }
            result.Reverse();

            return result;
        }

        public static int RotateNumber(List<int> numbers)
        {
            var firstDigit = numbers[0];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Count - 1] = firstDigit;

            var currentRotatedNumber = int.Parse(string.Join("", numbers));
            return currentRotatedNumber;
        }
    }
}
