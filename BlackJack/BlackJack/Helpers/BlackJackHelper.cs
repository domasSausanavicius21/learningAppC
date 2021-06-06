using BlackJack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Helpers
{
    class BlackJackHelper
    {

        /// <summary>
        /// Calculates points and decides the winner
        /// </summary>
        /// <param name="player"></param>
        /// <param name="dealer"></param>
        public static void calculateWinner(Player player, Player dealer, Player balance)
        {
            if (player.points == 21 && dealer.points != 21)
            {
                Console.WriteLine("Congratulations, {0} just got a BlackJack! {0} wins!", player.name);
                balance.balance += balance.bet;
            }
            else if (player.points > dealer.points && player.points <= 21)
            {
                Console.WriteLine("{0} wins!", player.name);
                balance.balance += balance.bet;
            }
            else if (dealer.points > 21)
            {
                Console.WriteLine("{0} wins!", player.name);
                balance.balance += balance.bet;
            }
            else if (dealer.points == player.points)
            {
                Console.WriteLine("It's a draw!");
            }
            else if (dealer.points == 21 && player.points != 21)
            {
                Console.WriteLine("{0} wins!", dealer.name);
                balance.balance -= balance.bet;
            }
            else if (player.points < dealer.points && dealer.points <= 21)
            {
                Console.WriteLine("{0} wins!", dealer.name);
                balance.balance -= balance.bet;
            }
            else if (player.points > 21)
            {
                Console.WriteLine("{0} wins!", dealer.name);
                balance.balance -= balance.bet;
            }
            else if (player.points == 21 && dealer.points == 21)
            {
                Console.WriteLine("Both {0} and {1} got a BlackJack. It's a draw.", player.name, dealer.name);
            }


            Console.WriteLine("Current {0} balance: {1}", balance.name, balance.balance);
         

        }
    }
}
