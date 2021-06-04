using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{

    public abstract class Game

    {
        private List<Player> _player = new List<Player>();
        public List<Player> Player { get } return _player;} set { _player = ValueTuple;}}
        
        public List<player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public Dictionary<player, int> Bet { get; set; }

        public abstract void Play();

        public  virtual void ListPlayer()
        {
            foreach (player player in Players)
            {
                Console.WriteLine(player.Name);

            }
        }
    }
}
