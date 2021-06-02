using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public class card
    {
        public Suit Suit { get; set; }
        public string Face { get; set; }
    }
    public enum Suit
    {
        Clubs=4,
        Diamonf=10,
        Hearts=12,
        Spades=15,
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
          
    }

   
       
