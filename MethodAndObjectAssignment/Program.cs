using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.FirstName = "sample";
            person.LastName = "student";

            person.SayName();

            Console.ReadLine();

        }
    }
}
