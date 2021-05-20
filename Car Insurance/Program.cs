using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("have you ever had a DUI? answer 'true' or 'false'");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("how many speeding tickets have you had?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            if (age < 15 || DUI != false || tickets <3 );
            {
                Console.WriteLine("You qualify");
            }
            
    }
}
