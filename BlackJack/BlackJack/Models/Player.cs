using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    class Player
    {
        public PlayingCard[] hand;
        public int cardsInHand;
        public int points;
        public string name;
        public int balance;
        public int bet;

        public Player()
        {
            hand = new PlayingCard[5];
            cardsInHand = 0;
            points = 0;
        }

        public Player clone()
        {
            Player player = new Player();
            player.name = name + " split";
            player.balance = balance;
            player.bet = bet;
            return player;
        }

        public void outputHand()
        {
            // Prints current hand
            Console.Write("Current Hand: ");
            
            for (int i = 0; i < cardsInHand; i++)
            {
                hand[i].outputCardSymbol();
            }
            Console.WriteLine("Current points: {0}.", points);
        }
        /// <summary>
        /// New card is added to players hand
        /// </summary>
        /// <param name="deck">PlayingCard array</param>
        /// <param name="pointer">indicator which card should be drawn from the deck</param>
        public void drawCard(PlayingCard[] deck, ref int pointer)
        {
            PlayingCard nextCard = deck[pointer];

            if (cardsInHand < 10)
            {
                hand[cardsInHand] = nextCard;

                cardsInHand++;

                points += nextCard.Points;

                pointer++;
            }
        }

        public void createSingleCard(PlayingCard card)
        {
            if (cardsInHand < 10)
            {
                hand[cardsInHand] = card;

                cardsInHand++;

                points += card.Points;

                
            }
        }


        /// <summary>
        /// Check if the player has more than 21 points and print the player's point total
        /// </summary>
        /// <returns></returns>
        public bool checkPoints()
        {
            // Check if the player is bust
            if (points > 21)
            {
                Console.WriteLine("Bust!");
                return false;
            }
            return true;
        }

        public bool checkDealerPoints()
        {
            // Check if the player is bust
            if (points > 21)
            {
                Console.WriteLine("Bust!");
                return false;
            }
            
            if (points >= 17)
            {
                Console.WriteLine("Dealer stops.");
                return false;
            }

            return true;
        }


        /// <summary>
        /// Check if the player has any aces with a point value of 11 (high). If player is about to bust, Ace is changed from 11 to 1
        /// </summary>
        public void checkAces()
        {
            bool changed = false;
            if (points > 21)
            {
                for (int i = 0; i < cardsInHand; i++)
                {
                    if (hand[i].Points == 11 && changed == false)
                    {
                        hand[i].Points = 1;

                        points -= 10;

                        changed = true;
                    }
                }
            }
        }

        public void clearCardsInHand()
        {
            hand = new PlayingCard[10];
            cardsInHand = 0;
            points = 0;
        }

        public void playTurn(ref bool stillOk, PlayingDeck deck, ref int pointer, PlayingCard card1, PlayingCard card2)
        {
            createSingleCard(card1);
            createSingleCard(card2);


            // Check if player has any Aces, output what's in the hand and check how many points the player have
            checkAces();
            outputHand();
            checkPoints();


            string playersChoice = "Pending";

            while (stillOk == true && playersChoice != "STAND")
            {
                Console.Write("Hit or Stand?");
                playersChoice = Console.ReadLine().ToUpper();
                if (playersChoice == "HIT")
                {
                    drawCard(deck.PlayingCards, ref pointer);

                    // If player has less than 21, stillOk remains true
                    // If the player more than 21, stillOk will become false and the loop stops
                    checkAces();
                    outputHand();
                    stillOk = checkPoints();
                }
            }

        }
    }
}
