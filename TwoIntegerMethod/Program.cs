using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            int y = Convert.ToInt32(Console.ReadLine());

            IntigerTwo myMath = new IntigerTwo();
            if (y == 0)
            {
                int result = myMath.Subtraction(x);
                Console.WriteLine(result);
              
            }
            else
            {
                int result = myMath.Subtraction(x, y);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
