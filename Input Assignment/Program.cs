using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number here!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            using  (StreamWriter file = new StreamWriter(@"c:\User\Documents\IO.txt", true))
            {
                file.WriteLine(number);
            }
        }
    }
}
