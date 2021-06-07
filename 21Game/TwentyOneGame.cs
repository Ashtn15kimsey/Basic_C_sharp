using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Playe()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bets);
                    if (!validAnswer) Console.WriteLine("please enter digits only, no decimals");
                }
                if(bet < 0)
                {
                    throw new FraudException("Security! Kicks this person out.");
                }
                bool succesfullyBet = player.Bets(bets);
                if (!succesfullyBet)
                {
                    return;
                    
                }
                Bets[Player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Player)
                {

                }
            }
        }
    }
}
