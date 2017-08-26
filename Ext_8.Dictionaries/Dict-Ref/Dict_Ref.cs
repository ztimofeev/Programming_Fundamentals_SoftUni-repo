namespace Dict_Ref
{
    using System;
    using System.Collections.Generic;

    public class Dict_Ref
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            Dictionary<string, int> result = new Dictionary<string, int>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split();

                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    result[firstElement] = number;
                }
                else if (result.ContainsKey(lastElement))
                {
                    result[firstElement] = result[lastElement];
                }

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
