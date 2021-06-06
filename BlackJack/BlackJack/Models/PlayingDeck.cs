using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    class PlayingDeck
    {
        public PlayingCard[] PlayingCards;

        public PlayingDeck()
        {
            PlayingCards = generateDeck();
            shuffleDeck();
        }
        /// <summary>
        /// Generates the deck
        /// </summary>
        /// <returns>Returns generated deck</returns>
        /// 
        private PlayingCard[] generateDeck()
        {
            PlayingCard[] deck = new PlayingCard[52];
            int counter = 0;
            
            for (int suit = 1; suit < 5; suit++)
            {
                for (int value = 1; value < 14; value++)
                {
                    deck[counter] = new PlayingCard(suit, value);
                    counter++;
                }
            }
            return deck; 
        }

        /// <summary>
        /// Shuffle the deck
        /// </summary>
        private void shuffleDeck()
        {
            Random rnd = new Random();
            PlayingCard temp;
            int number; 

            for (int i = 0; i < PlayingCards.Length; i++)
            {
                number = rnd.Next(0, PlayingCards.Length);

                temp = PlayingCards[i];

                PlayingCards[i] = PlayingCards[number];

                PlayingCards[number] = temp;
            }
        }
    }
}
