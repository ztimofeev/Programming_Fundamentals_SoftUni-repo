namespace StringDecryption
{
    using System;
    using System.Linq;

    public class StringDecryption
    {
        public static void Main()
        {
            var specNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var skipNum = specNumbers[0];
            var takeNum = specNumbers[1];

            var numbersToChar = Console.ReadLine()
                            .Split().Select(int.Parse)
                            .Where(x => x >= 65 && x <= 90)
                            .Skip(skipNum)
                            .Take(takeNum)
                            .Select(x => (char)x)
                            .ToList();

            Console.WriteLine(string.Join("", numbersToChar));
        }
    }
}
