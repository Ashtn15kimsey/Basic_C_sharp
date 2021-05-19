using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = ("Anonyous Income Comparsion Program");
            Console.WriteLine(welcome);
            Console.ReadLine();

            string person1 = ("person1");
            Console.WriteLine(person1);
            Console.ReadLine();

            Console.WriteLine("hourly rate?");
            int person1Rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hours worked per week?");
            int person1Hours = Convert.ToInt32(Console.ReadLine());

            string person2 = ("person2");
            Console.WriteLine(person2);
            Console.ReadLine();

            Console.WriteLine("hourly rate?");
            int person2Rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hours worked per week?");
            int person2Hours = Convert.ToInt32(Console.ReadLine());

            int weeks1 = 15;
            double result = person1Rate * person1Hours * weeks1;
            Console.WriteLine("anual salary for person1");
            Console.ReadLine();

            int weeks2 = 45;
            double result6 = person2Rate * person2Hours * weeks2;
            Console.WriteLine("anual salray for person2");
            Console.ReadLine();

            bool result3 = weeks1 > weeks2;
            Console.WriteLine("does person 1 make more than person 2?:\n" + result3);
            Console.ReadLine();


           
        }
        
               
        
           


            

    }
}
