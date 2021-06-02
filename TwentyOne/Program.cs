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

            //int count = deck.cards.Count(x => x.Face == Face.Ace);

            List<card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            foreach (card card in newList)
            
            Console.WriteLine(count);

           
            
            
           // deck.Shuffle(3);

            //foreach (card card in deck.cards)
            //Console.WriteLine(deck.cards.Count);
            Console.ReadLine();
           


        }
        
       
        
    }
}
