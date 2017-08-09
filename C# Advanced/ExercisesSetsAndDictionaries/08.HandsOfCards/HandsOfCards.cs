using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.HandsOfCards
{
    class HandsOfCards
    {
        static void Main()
        {
            var playersScores = new Dictionary<string, List<string>>();

            var command = Console.ReadLine();

            while (command.ToLower() != "joker")
            {
                var input = command.Split(':');
                var name = input[0];
                var hands = input[1]
                    .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();          

                if (!playersScores.ContainsKey(name))
                {
                    playersScores.Add(name, hands);
                }

                playersScores[name].AddRange(hands);

                command = Console.ReadLine();
            }

            foreach (var player in playersScores)
            {
                Console.WriteLine($"{player.Key}: {CalculateResult(player.Value)}");
            }
        }

        public static int CalculateResult(List<string> cards)
        {
            var result = 0;

            foreach (var hand in cards.Distinct())
            {
                
                var power = 0;
                var type = 0;

                var cardPower = hand.Substring(0, hand.Length - 1);
                var cardType = hand[hand.Length - 1];

                var nonNumberPowers = new string[] { "J", "Q", "K", "A" };

                if (nonNumberPowers.Contains(cardPower))
                {
                    switch (cardPower)
                    {
                        case "J":
                            power = 11;
                            break;
                        case "Q":
                            power = 12;
                            break;
                        case "K":
                            power = 13;
                            break;
                        case "A":
                            power = 14;
                            break;
                    }
                }
                else
                {
                    power = int.Parse(cardPower);
                }

                switch (cardType)
                {
                    case 'S':
                        type = 4;
                        break;
                    case 'H':
                        type = 3;
                        break;
                    case 'D':
                        type = 2;
                        break;
                    case 'C':
                        type = 1;
                        break;
                }

                result += (power * type);

            }

            return result;
        }
    }
}
