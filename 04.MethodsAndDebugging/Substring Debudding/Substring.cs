using System;
using System.Linq;

public class Substring_broken
{
    public static void Main()
    {
        var text = Console.ReadLine().Split().ToArray();
        int jump = int.Parse(Console.ReadLine());

        bool hasMatch = false;

        foreach (var word in text)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'p')
                {
                    hasMatch = true;

                    int subStringLenght = i + jump;

                    if (subStringLenght >= word.Length)
                    {
                        subStringLenght = word.Length - 1 - i;
                    }
                    else
                    {
                        subStringLenght = jump;
                    }

                    string matchedString = word.Substring(i, subStringLenght + 1);
                    Console.WriteLine(matchedString);

                    i += jump;
                }
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
