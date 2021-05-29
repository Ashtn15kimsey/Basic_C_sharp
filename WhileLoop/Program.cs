using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool IsGuessed = number == 14;

            do
            {
                switch (number)
                {

                    case 13:
                        Console.WriteLine("you gussed 13. try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("you guessed 6. try again");
                        Console.WriteLine("guess a numner");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 45:
                        Console.WriteLine("you gussed 45. try agin");
                        Console.WriteLine("guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 14:
                        Console.WriteLine("you gussed 14. That is is correct");
                        IsGuessed = true;
                        break;

                    default:
                        Console.WriteLine("you are wrong");
                        Console.WriteLine("guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;







                }

            }

            while (!IsGuessed);

            Console.ReadLine();
        }
    }
}
