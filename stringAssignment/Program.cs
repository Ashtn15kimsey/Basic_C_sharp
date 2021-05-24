using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // string conc. method
            string fname = "Ash";
            string lname = "kimsey";
            string MiddleName = "michael";
            string name = string.Concat(fname, lname, MiddleName);

            // converting string to uppercase
            string coolName = "Ash";
            string upperCase = coolName.ToUpper();

            // Creatin a StringBuilder
            StringBuilder sb = new StringBuilder("Hello Ash");



            Console.WriteLine(sb);
            Console.ReadLine();
             
        }
    }
}
