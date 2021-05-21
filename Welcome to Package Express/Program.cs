using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_to_Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Package express, please follow the instruction below!");
            Console.ReadLine();

            Console.WriteLine("please enter the weight of package ");
            int packageweight = Convert.ToInt32(Console.ReadLine());


            if (packageweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.”");
                Console.ReadLine();
            }

            Console.WriteLine("Please enter the package width");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter thw height of the package");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the package length");
            int length = Convert.ToInt32(Console.ReadLine());

            if (width + height + length > 50)
            { 

                Console.WriteLine("“Package too big to be shipped via Package Express.”");
                Console.ReadLine();
            }

            double total = (height * width * length) * packageweight / 100;
            Console.WriteLine("The cost of shipment in dollar: \n$" + total);
            Console.ReadLine();
            






        }
    }
}
