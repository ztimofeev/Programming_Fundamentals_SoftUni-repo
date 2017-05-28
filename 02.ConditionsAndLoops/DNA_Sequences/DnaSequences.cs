namespace DNA_Sequences
{
    using System;

    public class DnaSequences
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                string letter1 = SetLetter(i);
                for (int j = 1; j <= 4; j++)
                {
                    string letter2 = SetLetter(j);
                    for (int k = 1; k <= 4; k++)
                    {
                        string letter3 = SetLetter(k);
                        var sum = i + j + k;
                        string match;

                        if (sum >= num)
                        {
                            match = "O";
                        }
                        else
                        {
                            match = "X";
                        }

                        Console.Write($"{match}{letter1}{letter2}{letter3}{match} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static string SetLetter(int number)
        {
            switch (number)
            {
                case 1:
                    return "A";
                case 2:
                    return "C";
                case 3:
                    return "G";
                case 4:
                    return "T";
            }
            return null;
        }
    }
}
