using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Week day = new Week();

            try
            {
                Console.WriteLine("enter the current day of the week", day);
                Week.DaysOfTheWeek answer = (Week.DaysOfTheWeek)Enum.Parse(typeof(Week.DaysOfTheWeek), Console.ReadLine());

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter and acuall day of the week", day);
            }
        }
    }
}
           
           

           
    
        
        
            
            
            
            
            
        
       
        


        






    
