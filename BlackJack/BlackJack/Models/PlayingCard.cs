using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    class PlayingCard
    {
        public string Suit;
        public int Value;
        public int Points;

        public PlayingCard(int s, int v)
        {
            Value = v; 
            switch (s) 
            {
                case 1: // If s == 1, then set the Suit to Clubs
                    Suit = "♣";
                    break;
                case 2: // If s == 2, then set the Suit to Diamonds
                    Suit = "♦";
                    break;
                case 3: // If s == 3, then set the Suit to Hearts
                    Suit = "♥";
                    break;
                case 4: // If s == 4, then set the Suit to Spades
                    Suit = "♠";
                    break;
            }

            if (Value > 10)
            {
                Points = 10;
            }
            else if (Value == 1) // If it's an ace
            {
                Points = 11; // Set the points to 11
            }
            else
            {
                Points = Value;
            }
        }
        /// <summary>
        /// Output the details of a card using symbols A♠
        /// </summary>
        public void outputCard()
        {
            switch (Value) // Case statement based on the value of card
            {
                // Case for 1 - "The Ace of ..."
                case 1:
                    Console.WriteLine("Ace of {0}", Suit);
                    break;

                // Case for 11 - "The Jack of ..."
                case 11:
                    Console.WriteLine("Jack of {0}", Suit);
                    break;

                // Case for 12 - "The Queen of ..."
                case 12:
                    Console.WriteLine("Queen of {0}", Suit);
                    break;

                // Case for 13 - "The King of ..."
                case 13:
                    Console.WriteLine("King of {0}", Suit);
                    break;
                // Case for everything else 
                default:
                    Console.WriteLine("{0} of {1}", Value, Suit);
                    break;
            }
        }

        public void outputCardSymbol()
        {
            switch (Value) // Case statement based on the value of card
            {
                // Case for 1 - "The Ace of ..."
                case 1:
                    Console.Write("A{0} ", Suit);
                    break;

                // Case for 11 - "The Jack of ..."
                case 11:
                    Console.Write("J{0} ", Suit);
                    break;

                // Case for 12 - "The Queen of ..."
                case 12:
                    Console.Write("Q{0} ", Suit);
                    break;

                // Case for 13 - "The King of ..."
                case 13:
                    Console.Write("K{0} ", Suit);
                    break;
                // Case for everything else 
                default:
                    Console.Write("{0}{1} ", Value, Suit);
                    break;
            }
        }

        public string outputCardString()
        {
            switch (Value) // Case statement based on the value of card
            {
                // Case for 1 - "The Ace of ..."
                case 1:
                    return string.Format("A{0} ", Suit);

                // Case for 11 - "The Jack of ..."
                case 11:
                    return string.Format("J{0} ", Suit);

                // Case for 12 - "The Queen of ..."
                case 12:
                    return string.Format("Q{0} ", Suit);

                // Case for 13 - "The King of ..."
                case 13:
                    return string.Format("K{0} ", Suit);

                // Case for everything else 
                default:
                    return string.Format("{0}{1} ", Value, Suit);
            }
        }


    }

}
