using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck deck { get; set; }
        public int Balance { get; set; }

        public boid Deal(List<Card> Hand)
        {
            Hand.Add(deck.Cards.First());
            string card = string.Format(deck.Cards.First().ToString() + "\n");
            Console.WriteLine(deck.Cards.First().ToString() + "\n");
            using (StreamWriter file = new StreamWriter(@"C:\G\text.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            deck.Cards.RemoveAt(0);
        }
    }
}
