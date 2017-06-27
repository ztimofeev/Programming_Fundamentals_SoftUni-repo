namespace Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var startIndex = 0;
            var longerLenght = 1;
            var counter = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;
                    if (longerLenght < counter)
                    {
                        startIndex = i - counter + 1;
                        longerLenght = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = startIndex; i < startIndex + longerLenght; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
