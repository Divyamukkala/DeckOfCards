using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class CompareCards
    {
        public List<int> CompareCard(List<int> player1Cards, List<int> player2Cards, int rounds, int player1Score, int player2Score)
        {
            // Compare cards for 5 rounds
            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"Round {i + 1}:");
                Console.WriteLine($"Player 1 Card: {player1Cards[i]} vs Player 2 Card: {player2Cards[i]}");

                if (player1Cards[i] > player2Cards[i])
                {
                    player1Score++;
                    Console.WriteLine("Player 1 wins this round!");
                }
                else if (player2Cards[i] > player1Cards[i])
                {
                    player2Score++;
                    Console.WriteLine("Player 2 wins this round!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }
                Console.WriteLine();
            }
            // Display the final scores
            Console.WriteLine("Final Scores:");
            Console.WriteLine($"Player 1: {player1Score}");
            Console.WriteLine($"Player 2: {player2Score}");
            List<int> result = new List<int>();
            result.Add(player1Score);
            result.Add(player2Score);
            return result;
        }
    }
}
