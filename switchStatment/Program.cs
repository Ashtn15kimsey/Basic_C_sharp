using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number ==12;


            while (!isGuessed)
            {
                switch (number)
                {
                    case 62:

                        Console.WriteLine("you guessed 62. Try again");
                        Console.WriteLine("Guess number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("you guessed 29. Try again");
                        Console.WriteLine("Guess number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed number 12. You are correct");
                        break;
                    default:
                        Console.WriteLine("you are wrong");
                        Console.WriteLine("Guess number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            Console.ReadLine();
            
            
        }
    }
}
