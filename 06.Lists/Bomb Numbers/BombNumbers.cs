namespace Bomb_Numbers
{
    using System;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var explosives = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bomb = explosives[0];
            var bombPower = explosives[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    var start = Math.Max(0, i - bombPower);
                    var end = Math.Min(i + bombPower, numbers.Count - 1);
                    var range = end - start + 1;
                    numbers.RemoveRange(start, range);
                    i = -1;
                }
            }

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
        
    }
}
