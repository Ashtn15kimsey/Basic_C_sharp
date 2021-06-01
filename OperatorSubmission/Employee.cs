using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSubmission
{
    class Employee : Person 
    {
        public int ID { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is null)  return false;
            if (ReferenceEquals(this, obj)) return true;

            if (obj.GetType() != this.GetType()) return false;

            return this.ID.Equals(((Employee)obj).ID);

        }





    }
}
