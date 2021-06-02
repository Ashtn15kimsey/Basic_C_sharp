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
            card card1 = new card();
            card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);
            
            
            
            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (card card in deck.cards)
            //Console.WriteLine(deck.cards.Count);
            Console.ReadLine();
           


        }
        
       
        
    }
}
