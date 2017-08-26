namespace FindTheLetter
{
    using System;
    using System.Linq;

    public class FindTheLetter
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var seekingParams = Console.ReadLine().Split();
            char letterToFind = char.Parse(seekingParams[0]);
            var countOfAccurance = int.Parse(seekingParams[1]);
            var result = 0;
            bool isTrue = false;

            if (text.Contains(letterToFind))
            {
                var count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == letterToFind)
                    {
                        count++;
                        if (count == countOfAccurance)
                        {
                            result = i;
                            isTrue = true;
                            break;
                        }
                    }
                }
            }

            if (isTrue)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
