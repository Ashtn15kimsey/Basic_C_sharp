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
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string> { "ash","Tom","bill"}
            game.ListPlayer();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(5);
           
            //foreach (card card in deck.cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.cards.Count);
            //Console.ReadLine();


        }
        
       
        
    }
}
