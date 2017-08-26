namespace Key_Key_Value_Value
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Key_Key_Value_Value
    {
        public static void Main()
        {
            var seekingKey = Console.ReadLine();
            var seekingValue = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> tokens = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var dataLine = Console.ReadLine().Split(new string[] {" => "}, StringSplitOptions.RemoveEmptyEntries);
                var dataKey = dataLine[0];
                var dataValues = dataLine[1].Split(';').ToList();

                tokens.Add(dataKey, dataValues);
            }

            foreach (var line in tokens)
            {
                if (line.Key.Contains(seekingKey))
                {
                    Console.WriteLine($"{line.Key}:");
                    foreach (var item in line.Value)
                    {
                        if (item.Contains(seekingValue))
                        {
                            Console.WriteLine($"-{item}");
                        }
                    }
                }
            }
        }
    }
}
