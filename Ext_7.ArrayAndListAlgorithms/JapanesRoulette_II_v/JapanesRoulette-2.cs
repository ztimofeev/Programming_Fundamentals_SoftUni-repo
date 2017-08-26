using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> theList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> players = Console.ReadLine().Split(' ').ToList();
            int muzzlePosition = 0;
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i] == 1)
                {
                    muzzlePosition = i;
                }
            }

            int playerPosition = 0;
            for (int i = 0; i < players.Count; i++)
            {
                string[] temp = players[i].Split(',').ToArray();
                string command = temp[1];
                int strength = int.Parse(temp[0]);
                if (command == "Left")
                {
                    playerPosition = (muzzlePosition - strength) % theList.Count;
                    if (playerPosition < 0)
                    {
                        playerPosition += theList.Count;
                    }
                }
                else if (command == "Right")
                {
                    playerPosition = (muzzlePosition + strength) % theList.Count;
                }

                muzzlePosition = playerPosition;

                if (playerPosition == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    return;
                }
                muzzlePosition++;
            }
            Console.WriteLine("Everybody got lucky!");
        }
    }
}