using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    public class OddFilter
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).Where(n => n % 2 == 0).ToArray();
            var avr = numbers.Average();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > avr)
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
