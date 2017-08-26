using System;
using System.Collections.Generic;
using System.Linq;

namespace Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            List<int> ladybugsPositions = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] playground = new int[range];

            for (int i = 0; i < range; i++)
            {
                if (ladybugsPositions.Contains(i))
                {
                    playground[i] = 1;
                }
                else
                {
                    playground[i] = 0;
                }
            }

            var command = Console.ReadLine();

            while (command != "end")
            {
                var inputTokens = command.Split();
                string direction = inputTokens[1];
                int ladybugToMove = int.Parse(inputTokens[0]);
                int flylength = int.Parse(inputTokens[2]);

                if (ladybugToMove >= 0 && ladybugToMove < playground.Length && playground[ladybugToMove] == 1)
                {
                    playground[ladybugToMove] = 0;

                    switch (direction)
                    {
                        case "left":
                            for (int i = ladybugToMove - flylength; i >= 0; i--)
                            {
                                if (playground[i] == 0)
                                {
                                    playground[i] = 1;
                                    break;
                                }
                            }
                            break;

                        case "right":
                            for (int i = ladybugToMove + flylength; i < playground.Length; i += flylength)
                            {
                                if (playground[i] == 0)
                                {
                                    playground[i] = 1;
                                    break;
                                }
                            }
                            break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", playground));
        }
    }
}
