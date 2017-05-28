namespace CountOfIntegers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var countOfDigits = 0;
            bool flag = true;

            while (flag)
            {
                int digit;
                if (int.TryParse(input, out digit))
                {
                    countOfDigits++;
                    input = Console.ReadLine();
                }
                else
                {
                    flag = false;
                }
            }

            Console.WriteLine(countOfDigits);
        }
    }
}
