using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
   public class Player
    {
        public Player(string name) : this(name, 100)
        {
        }

        public Player(string name, int begginingBalance)
        {

            Hand = new List<Card>();
            Balance = begginingBalance;
            name = name;

        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bets(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place at bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

       
    }
    public static Game operator+ (Game game, Player player)
    {
        game.players.Add(player);
    }
    public static Game operator- (Game game, Player player)
    {
        game.players.Remove(player);
        reuturn game;
       }
    }
}

