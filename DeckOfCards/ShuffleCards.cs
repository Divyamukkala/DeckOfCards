using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class ShuffleCards
    {
        // Method to shuffle the cards
        public ShuffleCards(List<int> deck) 
        {          
            Random rand = new Random();
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                int temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }           
        }
    }
}
