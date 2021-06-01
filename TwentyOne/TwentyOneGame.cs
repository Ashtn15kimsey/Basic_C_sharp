using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public class TwentyOneGame : Game, IwalkAway
    {
        public  override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayer()
        {
            Console.WriteLine("Welcome to 21 players");
            base.ListPlayer();
        }
        public void walkAway(player player)
        {
            throw new NotImplementedException();
        }
    }
}
