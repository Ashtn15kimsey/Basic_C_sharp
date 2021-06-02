using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "Jim";
            example.LastName = "Peter";
            example.ID = 25555;

            Employee example2 = new Employee();

            example2.FirstName = "Andy";
            example2.LastName = "Roberts";
            example2.ID =  347689;

            bool condition = true;
           if (example == example2)
            {
                Console.WriteLine("Its equal");
            }
            else
            {
                Console.WriteLine("It is not equal");
            }
            

            Console.ReadLine();
        }
    }
}
