using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            List<long> aliveBees = new List<long>();

            for (int i = 0; i < beehives.Count; i++)
            {
                long hornetPower = hornets.Sum();

                if (hornetPower > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else if (hornetPower == beehives[i])
                {
                    hornets.RemoveAt(0);
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    long reminingBees = beehives[i] - hornetPower;
                    aliveBees.Add(reminingBees);
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                }
            }

            var result = new List<long>();

            if (aliveBees.Count > 0)
            {
                result = aliveBees;
            }
            else
            {
                result = hornets;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
