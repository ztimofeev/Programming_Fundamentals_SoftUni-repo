namespace ByteFlip
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ByteFlip
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Where(x => x.Length == 2)
                .ToList();

            List<char> reverstItems = new List<char>();
            foreach (var item in input)
            {
                string result = "";
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    result += item[i];
                }
                var temp = Convert.ToInt32(result, 16);

                reverstItems.Add((char)temp);
            }

            reverstItems.Reverse();

            Console.WriteLine(string.Join("", reverstItems));
        }
    }
}
