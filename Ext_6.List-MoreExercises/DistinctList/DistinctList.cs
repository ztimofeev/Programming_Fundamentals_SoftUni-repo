namespace DistinctList
{
    using System;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                        j--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));            
        }
    }
}

