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
            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    card card = new card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    cards.Add(card);
                }
            }
         }
        public List<card> cards { get; set; }

        public void Shuffle(int times = 1)

        {
            
            for (int i = 0; i < times; i++)
            {

                
                List<card> TempList = new List<card>();
                Random random = new Random();

                while (cards.Count > 0)
                {
                    int randomIndex = random.Next(0, cards.Count);
                    TempList.Add(cards[randomIndex]);
                    cards.RemoveAt(randomIndex);
                }
                cards = TempList;
            }

            


        }
    }
}
