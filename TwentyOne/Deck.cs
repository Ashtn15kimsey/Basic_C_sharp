using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class Deck
    {
        public Deck()
        {
            cards = new List<card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Dimaond", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"

            };
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    card card = new card();
                    card.Suit = suit;
                    card.Face = face;
                    cards.Add(card);

                }
            }




        }
        public List<card> cards { get; set; }
    }
}
