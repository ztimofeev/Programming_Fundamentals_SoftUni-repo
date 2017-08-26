namespace Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Batteries
    {
        public static void Main()
        {
            var cap = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var usage = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var hours = int.Parse(Console.ReadLine());

            double durability;
            double rest;

            for (int i = 0; i < cap.Length; i++)
            {
                rest = cap[i] - hours * usage[i];
                durability = rest / cap[i] * 100;
                if (rest >= 0)
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", i + 1, rest, durability);
                }
                else
                {
                    durability = Math.Ceiling(cap[i] / usage[i]);
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i + 1, durability);
                }
            }
        }
    }
}
