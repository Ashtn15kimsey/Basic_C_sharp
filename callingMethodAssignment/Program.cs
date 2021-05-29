using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Operations myMath = new Operations();
            // Thre diffirent operations the users input goes through
            int result = myMath.Addition(userInput);
            int result2 = myMath.Subtraction(userInput);
            int result3 = myMath.Division(userInput);
           
            // The three different operations are then prsented on the screen.
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();

        }
        
    }
    
}
