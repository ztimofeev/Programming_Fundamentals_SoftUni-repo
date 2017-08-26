namespace CountSubstringAccurance
{
    using System;

    public class CountSubstringAccurance
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();

            int accurance = 0;
            int index = -1;

            while (true)
            {
                index = text.IndexOf(substring, index + 1);
                if (index < 0)
                {
                    break;
                }
                accurance++;
            }

            Console.WriteLine(accurance);
        }
    }
}
