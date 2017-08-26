namespace RabbitHole
{
    using System;
    using System.Linq;

    class RabbitHole
    {
        static void Main(string[] args)
        {
            var commandLine = Console.ReadLine().Split().ToList();
            var power = int.Parse(Console.ReadLine());

            var currentIndex = 0;
            bool foundRabbitHole = false;
            bool putBomb = false;

            while (power > 0)
            {
                var tokens = commandLine[currentIndex].Split('|');
                var direction = tokens[0];
                

                if (direction == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    foundRabbitHole = true;
                    break;
                }

                var countPositions = int.Parse(tokens[1]);

                if (direction == "Right")
                {
                    currentIndex = (currentIndex + countPositions) % commandLine.Count;
                    power -= countPositions;
                }
                else if (direction == "Left")
                {
                    currentIndex = Math.Abs(currentIndex - countPositions) % commandLine.Count;
                    power -= countPositions;
                }
                else if (direction == "Bomb")
                {
                    commandLine.RemoveAt(currentIndex);
                    currentIndex = 0;
                    power -= countPositions;
                    if (power <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        putBomb = true;
                        break;
                    }
                }

                if (commandLine[commandLine.Count - 1] != "RabbitHole")
                {
                    commandLine.RemoveAt(commandLine.Count - 1);
                }

                commandLine.Add("Bomb|" + power);
            }

            if (!foundRabbitHole && !putBomb)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}
