using System;
using System.Collections.Generic;


namespace ExceptionalHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>();
                numbers.Add(6);
                numbers.Add(10);
                numbers.Add(14);
                Console.WriteLine("choose a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int numberThree = number / numberOne;
                    Console.WriteLine(number + "divide by" + numberOne + "equals:" + numberThree);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("please dont divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
