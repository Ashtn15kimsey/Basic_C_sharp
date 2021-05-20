using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND argument '&&'
            //int packageWidth = 5;
            //int packageHeight = 15;
            //bool tooBig = (packageHeight > 20 && packageWidth > 20);
            //Console.WriteLine(tooBig);
            //Console.ReadLine();

            // OR arguement symbol '||'
            //int packWwidth = 9;
            //int packageHeight = 10;
            //bool tooBig = (packageHeight > 7 || packWwidth > 7);
            //Console.WriteLine(tooBig);
            //Console.ReadLine();

            // More than one AND in expression argument

            string firstName = "Ash";
            string lastName = "kimsey";
            string socialSecurityNumber = "222-22-2222";

            bool isAuthorized = (firstName == "Ash" && lastName == "kimsey" && socialSecurityNumber == "222-22-2222");
            Console.WriteLine(isAuthorized);
            Console.ReadLine();
        }


    }
}
