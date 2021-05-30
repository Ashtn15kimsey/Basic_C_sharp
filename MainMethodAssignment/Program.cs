using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           Math a = new Math();
            int x = a.Subtraction(42);
            double p = a.Multiplication(24.7);
            int z = a.Division(4);

            Console.WriteLine(x);
            Console.WriteLine(p);
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
