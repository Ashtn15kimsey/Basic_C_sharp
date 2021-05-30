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
            Deck deck = new Deck();
            deck.Shuffle(5);
           
            foreach (card card in deck.cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.cards.Count);
            Console.ReadLine();


        }
        
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        }
    }
}
