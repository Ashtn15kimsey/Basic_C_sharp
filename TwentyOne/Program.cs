using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
     
            

            Console.WriteLine("Welcome to Ash's casino and bar. Lets start with your name");
            string PlayerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Helo, {0}. Would you like to play a game of 21?", PlayerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                player player = new player(PlayerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlayer = true;
                while (player.isActivePlayer && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");


            }
            Console.WriteLine("Feel free to look around the casino.Bye for now!");
            Console.ReadLine();



        }
        
       
        
    }
}
