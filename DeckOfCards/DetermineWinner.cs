using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class DetermineWinner
    {
        public string DetermineWinnerResult(int player1Score, int player2Score) 
        {
            // Determine the winner
            string result;
            if (player1Score > player2Score)
            {
                result = "Player 1 is the winner!";
                Console.WriteLine(result);
            }
            else if (player2Score > player1Score)
            {
                result = "Player 2 is the winner!";
                Console.WriteLine(result);
            }
            else
            {
                result = "It's a tie!";
                Console.WriteLine(result);
            }
            return result;
        }
    }
}
