using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> person = new Employee<string>();

            List<string> FistName = new List<string>()
            {
                "ash", "mike", "tom", "eric"
            };
            List<string> Lastname = new List<string>()
            {
                "brown","johnson","peters","homer"
            };
            foreach (var firsName in FistName)
            {
                Employee.Add(new Employee(firsName, FistName));
                
            }
            Console.WriteLine();
            person.SayName();
            Console.ReadLine();

        }
    }
}
