﻿using System;
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
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);
           


            foreach (card card in deck.cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.cards.Count);
            Console.WriteLine("Times Shuffled {0}", timesShuffled);
            Console.ReadLine();


        }
        public static Deck Shuffle(Deck deck, out int timesShuffle, int times = 1)

        {
            timesShuffle = 0;
            for (int i = 0; i < times; i++)
            {

                timesShuffle++;
                List<card> TempList = new List<card>();
                Random random = new Random();

                while (deck.cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.cards.Count);
                    TempList.Add(deck.cards[randomIndex]);
                    deck.cards.RemoveAt(randomIndex);
                }
                deck.cards = TempList;
            }
            
            return deck;


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
