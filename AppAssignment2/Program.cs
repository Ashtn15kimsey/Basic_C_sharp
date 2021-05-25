using System;
using System.Collections.Generic;


namespace AppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples\t", "pineApples\t", "pears\t" };
            Console.WriteLine("Add favortie fruit");
            string addFruit = Console.ReadLine();
            foreach (string frutis in fruits) ;
            {
                string NewFruit = fruits + addFruit;
                Console.WriteLine(newFruit);
                
            }
            Console.ReadLine();


        }
    }
}
