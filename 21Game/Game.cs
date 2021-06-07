using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();


        public List<Player> players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } { _bets = ValueTuple; } }

        public abstract void Playe();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(Player.Name)
            }
        }
    }
}
