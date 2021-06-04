using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageText;
            int age;
            int result = 0;

            Console.WriteLine("Please enter your age:");
            ageText = Console.ReadLine();

            try
            {
                age = int.Parse(ageText);
                Console.WriteLine("your are {age*12}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"The age you entered, {ageText}, is not valid");
                result = 1;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unexpexted error: {exception.Message}");
                result = 1;
            }
            Console.ReadLine();
                
        }
    }
}
        
            

           
                
