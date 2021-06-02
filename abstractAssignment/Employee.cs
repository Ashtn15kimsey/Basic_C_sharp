using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    public class Employee : person //IQuittable
    {
        public void SayName(string FirstName, string LastName)
        {
            base.SayName();
        }
    }
   // public void Quit(Employee person)
//    {
//        throw new NotImplementedException();
//    }
  }
//public static bool operator ==(Employee emp1, Employee ep2)
//      return Employee.


