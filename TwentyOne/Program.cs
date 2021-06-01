using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<player>();
            player player = new player();
            player.Name = "Ash";
            game += player;

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (card card in deck.cards)
            Console.WriteLine(deck.cards.Count);
            Console.ReadLine();
           


        }
        
       
        
    }
}
