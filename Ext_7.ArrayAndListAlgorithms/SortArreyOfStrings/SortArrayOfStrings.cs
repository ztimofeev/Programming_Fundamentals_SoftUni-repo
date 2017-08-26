namespace SortArrayOfSrting
{
    using System;
    using System.Linq;

    public class SortArrayOfString
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToArray();

            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (text[i].CompareTo(text[i + 1]) == 1)
                    {
                        var temp = text[i];
                        text[i] = text[i + 1];
                        text[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
