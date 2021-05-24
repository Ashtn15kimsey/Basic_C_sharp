using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            List<string > intList = new List<string >();
            intList.Add("Hello");
            intList.Add("Ash");
            intList.Remove("Ash");

            Console.WriteLine(intList[0]);
            Console.ReadLine();
                

            



            // exaple 1
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 500;

            ////exaple 2
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 500 };

            ////example 3
            //int[] numArray2 = { 5, 2, 10, 200, 500, 600, 2500 };
            //numArray2[5] = 700;

            

            Console.WriteLine();
            Console.ReadLine();
               


        }
    }
}
