using BlackJack.Helpers;
using BlackJack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackJack.Game
{
    class BlackJackGame
    {
        static int pointer = 0;

        public static void thePlay()
        {
            // Player
            Player player = new Player();
            Player splitHand = null;
            Console.Write("Please enter your name: ");
            player.name = Console.ReadLine();

            // Player deposit

            bool depositCorrect = false;
            int deposit = 0;
            do
            {
                Console.Write("Please enter your deposit: ");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    player.balance = result;
                    deposit = result;
                    depositCorrect = true;
                }
                else
                {
                    Console.WriteLine("Wrong deposit format. Please try again.");
                }
            } while (depositCorrect == false);



            // Create Dealer
            Player dealer = new Player();
            dealer.name = "Dealer";

            bool playAgain = true;

            do
            {
                PlayingDeck deck = new PlayingDeck(); // Generate & shuffle deck             
                
                
                // Player enters their bet

                bool betCorrect = false;

                do
                {
                    Console.Write("Please enter your bet: ");

                    if (int.TryParse(Console.ReadLine(), out int result))
                    {
                        if (result > player.balance)
                        {
                            betCorrect = false;
                            Console.WriteLine("Insufficient balance. Please try again.");
                        }
                        else
                        {
                            player.bet = result;
                            betCorrect = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong bet format. Please try again.");
                    }
                } while (betCorrect == false);

                // First two cards for the player
                PlayingCard card1 = deck.PlayingCards[pointer];
                pointer++;

                PlayingCard card2 = deck.PlayingCards[pointer];
                pointer++;

                bool stillOk = true;
                
                // Check if split is available
                if (card1.Value == card2.Value || card1.Points == card2.Points)
                {
                    Console.WriteLine("Player {0} has drawn {1} and {2}. Do you want to split? Y/N", player.name, card1.outputCardString(), card2.outputCardString());
                    string splitChoice = Console.ReadLine().ToUpper();
                    if (splitChoice == "Y")
                    {
                        stillOk = false;
                        
                        splitHand = player.clone();

                        PlayingCard card3 = deck.PlayingCards[pointer];
                        pointer++;

                        PlayingCard card4 = deck.PlayingCards[pointer];
                        pointer++;

                        player.playTurn(ref stillOk, deck, ref pointer, card1, card3);
                        splitHand.playTurn(ref stillOk, deck, ref pointer, card2, card4);

                        stillOk = true;
                    }
                    else
                    {
                        player.playTurn(ref stillOk, deck, ref pointer, card1, card2);
                    }
                }

                else
                {
                    player.playTurn(ref stillOk, deck, ref pointer, card1, card2);
                }

                /// Pretty much the same is happening with the dealer
                if (stillOk == true)
                {
                    bool dealerAlive = true;

                    Console.WriteLine();
                    Console.WriteLine("*** Dealer's Turn ***");
                    dealer.drawCard(deck.PlayingCards, ref pointer);
                    dealer.drawCard(deck.PlayingCards, ref pointer);

                    dealer.checkAces();
                    dealer.outputHand();
                    dealerAlive = dealer.checkDealerPoints();

                    while (dealerAlive == true)
                    {
                        Console.WriteLine("Dealer draws: ");

                        Thread.Sleep(2000);

                        dealer.drawCard(deck.PlayingCards, ref pointer);

                        dealer.checkAces();

                        dealer.outputHand();

                        dealerAlive = dealer.checkDealerPoints();
                    }
                }

                /// Calculate & output the winner
                BlackJackHelper.calculateWinner(player, dealer, player);

                if (splitHand != null)
                {
                    BlackJackHelper.calculateWinner(splitHand, dealer, player);
                    splitHand = null;
                }

                // Clear card in hand
                player.clearCardsInHand();
                dealer.clearCardsInHand();

                if (player.balance > 0)
                {
                    
                    if (player.balance >= deposit * 4)
                    {
                        playAgain = false;
                        Console.WriteLine("Casino has been generous enough. Goodbye!");
                    }
                    else
                    {
                        playAgain = true;
                    }
                }

                else
                {
                    playAgain = false;
                    Console.WriteLine("Insufficient funds. Please make a new deposit and start the game.");
                }
            } while (playAgain == true);
        }
    }

}

