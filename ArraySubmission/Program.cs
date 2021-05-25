using System;
using System.Collections.Generic;


namespace ArraySubmission
{
    class Program
    {
        static void Main()
        {
            string[] nameArray = new string[] { "apple", "PineApples", "pears" };
            Console.WriteLine("Choose fruit");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= 0 && index <=)
            {
                Console.WriteLine(nameArray[index]);
                Console.ReadLine();
            }

            int[] numArray = new int[] { 2, 4., 6, 56, 35 };
            Console.WriteLine("choose a number");
            int index2 = Convert.ToInt32(Console.ReadLine());
            if (index2 >= 0 && index2 <= 6)
            {
                Console.WriteLine(numArray[index2]);
            }
            else
            {
                Console.WriteLine("sorry that number does not exist");
            }
            List<string> intList = new List<string>();
            intList.Add("My Name is Ash");
            intList.Add("I'm 23 years old");
            intList.Remove("The sky is blue today");
            Console.WriteLine("select and index");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0 && x <= 1)
            {
                Console.WriteLine(intList[x]);
            }
            else
            {
                Console.WriteLine("sorry but that integer doesnt exist");
            }
            Console.ReadLine();


                



        }
    }
}
