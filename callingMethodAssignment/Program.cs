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

            int result = myMath.Addition(userInput);
            int result2 = myMath.Subtraction(userInput);
            int result3 = myMath.Division(userInput);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();

        }
        
    }
    
}
