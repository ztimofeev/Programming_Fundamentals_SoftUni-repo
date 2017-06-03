namespace Boat_Simulator
{
    using System;

    public class BoatSimulator
    {
        public static void Main()
        {
            var firstBoat = char.Parse(Console.ReadLine());
            var secondBoat = char.Parse(Console.ReadLine());
            var lines = byte.Parse(Console.ReadLine());

            var winner = "";
            var tilesFirsBoat = 0;
            var tilesSecondBoat = 0;
            bool isWinner = false;

            for (int i = 1; i <= lines; i++)
            {
                var command = Console.ReadLine();

                if (command != "UPGRADE" && i % 2 == 1)
                {
                    tilesFirsBoat += command.Length;

                    if (tilesFirsBoat >= 50)
                    {
                        winner = firstBoat.ToString();
                        isWinner = true;
                        break;
                    }
                }
                if (command != "UPGRADE" && i % 2 == 0)
                {
                    tilesSecondBoat += command.Length;

                    if (tilesSecondBoat >= 50)
                    {
                        winner = secondBoat.ToString();
                        isWinner = true;
                        break;
                    }
                }

                if (command == "UPGRADE")
                {
                    firstBoat = (char) (firstBoat + 3);
                    secondBoat = (char) (secondBoat + 3);
                }
            }

            if (isWinner == false)
            {
                if (tilesFirsBoat > tilesSecondBoat)
                {
                    winner = firstBoat.ToString();
                }
                else
                {
                    winner = secondBoat.ToString();
                }
            }
            
            Console.WriteLine(winner);
        }
    }
}
