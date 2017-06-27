using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' ', ':', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            List<string> hands = new List<string>();
            
            while (input[0] != "JOKER")
            {
                var player = input[0];

                if (!players.ContainsKey(player))
                {
                    players[player] = new List<string>();
                }

                for (int i = 1; i < input.Count; i++)
                {
                    var hand = input[i];
                    if (!players[player].Contains(hand))
                    {
                        players[player].Add(hand);
                    }
                }

                input = Console.ReadLine().Split(new[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var gambler in players)
            {
                var scores = GetPlayerScore(gambler.Value);
                Console.WriteLine($"{gambler.Key}: {scores}");
            }
        }

        private static int GetPlayerScore(List<string> list)
        {
            var cardPower = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var cardType = new[] { "C", "D", "H", "S" };
            var sum = 0;

            foreach (var card in list)
            {
                for (int i = 0; i < cardPower.Length; i++)
                {
                    for (int j = 0; j < cardType.Length; j++)
                    {
                        var current = cardPower[i] + cardType[j];
                        if (card == current)
                        {
                            sum += (i + 2) * (j + 1);
                        }
                    }
                }
            }

            return sum;
        }
    }
}
