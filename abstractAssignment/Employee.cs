using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    public class Employee : person, IQuittable
    {
        public void SayName(string FirstName, string LastName)
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("This  person has quit");
        }
    }
    
}





