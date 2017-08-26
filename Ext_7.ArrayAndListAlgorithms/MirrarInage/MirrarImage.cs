using System;
using System.Collections.Generic;
using System.Linq;

namespace MirrarImage
{
    public class MirrarImage
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var mirrarIndex = Console.ReadLine();

            while (mirrarIndex != "Print")
            {
                var index = int.Parse(mirrarIndex);
                input = LeftPartReversing(input, index);
                input = RightPartReversing(input, index);

                mirrarIndex = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }

        public static List<string> LeftPartReversing(List<string> lst, int index)
        {
            for (int i = 0; i < index / 2; i++)
            {
                var temp = lst[i];
                lst[i] = lst[index - 1 - i];
                lst[index - 1 - i] = temp;
            }

            return lst;
        }

        public static List<string> RightPartReversing(List<string> lst, int index)
        {
            for (int i = 0; i < (lst.Count - 1 - index) / 2; i++)
            {
                var temp = lst[index + 1 + i];
                lst[index + 1 + i] = lst[lst.Count - 1 - i];
                lst[lst.Count - 1 - i] = temp;
            }

            return lst;
        }
    }
}