using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IwalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (player player in players)
            {
                player.Hand = new List<card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach (player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullybet = player.Bet(bet);
                if (!successfullybet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing..");
                foreach (player player in player)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckFordBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32(Bets[player] * 1.5) + Bets[player]);
                            return;
        }
    }
}
Console.WriteLine("Dealer");
Dealer.Deal(Dealer.Hand);
if (if == 1)
    {
        bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
        if (blackJack)
        {
            Console.WriteLine("Dealer has BlackJack! ");
            foreach (KeyValuePair<player, int> entry in Bets)
            {
                Dealer.Balance += entry.Value;
            }
        }
    }
foreach (player player in player)
{
    while (!player.Stay)
    {
        Console.WriteLine("your cards are:");
        foreach (card card in player.Hand)
        {
            Console.WriteLine("{0}", card.ToString());
        }
        Console.WriteLine("\n\nHit or stay?");
        string answer = Console.ReadLine().ToLower();
        {
            player.Stay = true;
            break;
        }
        else if (answer == "hit")
        {
            Dealer.Deal(player.Hand);

        }
        bool busted = TwentyOneRules.isBusted(player.Hand);
        if (busted)
        {
            Dealer.Balance += bets[player];
            Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
            Console.WriteLine("Dyou want to play again?");
            answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah")
            {
                player.isActivelyPlaying = true;
            }
            else
            {
                player.isActivelyPlaying = false;
            }
        }
    }
}
Public over

                 