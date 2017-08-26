using System;
using System.Linq;

namespace JapaneseRoulette
{
    public class JapaneseRoulette
    {
        public static void Main()
        {
            var cylinder = Console.ReadLine().Split().ToArray();
            var playersChoice = Console.ReadLine().Split().ToArray();

            var muzzlePosition = 0;

            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == "1")
                {
                    muzzlePosition = i;
                    break;
                }
            }

            int playerPosition = 0;
            bool gameOver = false;

            for (int i = 0; i < playersChoice.Length; i++)
            {
                var player = playersChoice[i].Split(',').ToArray();

                var strength = int.Parse(player[0]);
                var direction = player[1];

                if (direction == "Right")
                {
                    playerPosition = (muzzlePosition + strength) % cylinder.Length;
                }
                else if (direction == "Left")
                {
                    playerPosition = (muzzlePosition - strength) % cylinder.Length;
                    if (playerPosition < 0)
                    {
                        playerPosition += cylinder.Length;
                    }
                }

                muzzlePosition = playerPosition;

                if (playerPosition == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    gameOver = true;
                    break;
                }
                
                muzzlePosition += 1;
            }

            if (!gameOver)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
