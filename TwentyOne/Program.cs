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
            deck = Shuffle(deck);


            foreach (card card in deck.cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.cards.Count);
            Console.ReadLine();


        }
        public static Deck Shuffle(Deck deck)
        {
            List<card> TempList = new List<card>();
            Random random = new Random();

            while (deck.cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.cards.Count);
                TempList.Add(deck.cards[randomIndex]);
                deck.cards.RemoveAt(randomIndex);
            }
            deck.cards = TempList;
            return deck;


        }
    }
}
