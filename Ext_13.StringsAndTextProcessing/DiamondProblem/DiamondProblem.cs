namespace DiamondProblem
{
    using System;

    public class DiamondProblem
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            int carats = 0;
            bool foundDiamond = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<' && i < input.Length - 1)
                {
                    i++;
                    while (input[i] != '>')
                    {
                        if (char.IsDigit(input[i]))
                        {
                            carats += int.Parse(input[i].ToString());
                        }

                        if (i == input.Length - 1)
                        {
                            carats = 0;
                            break;
                        }

                        i++;
                    }

                    if (carats != 0)
                    {
                        Console.WriteLine("Found {0} carat diamond", carats);
                        foundDiamond = false;
                        carats = 0;
                    }
                }
            }

            if (foundDiamond)
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}
