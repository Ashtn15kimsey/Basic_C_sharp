using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] names = { "Ash\t", "josh\t", "Jerry\t", "Peter\t" };

            //        Console.WriteLine("Add your name:\n");
            //        string AddName = Console.ReadLine();
            //        foreach (string name in names)
            //        {
            //            string NewName = name + AddName;
            //            Console.WriteLine(NewName);
            //        }
            //        Console.ReadLine();

            //        //infninite loop
            //        for (int a = 0; a < 50; a--)
            //        {
            //            Console.WriteLine("ininite loop: {0}", 0);
            //    }
            //    Console.ReadLine();

            //    //loop comparassion
            //    int num;
            //    num = 0;
            //    while (num < 40)
            //    {
            //        Console.WriteLine(num);
            //        num++;
            //    }
            //    int num2;
            //    num2 = 0;
            //    while (num2 <= 20)
            //    {
            //        Console.WriteLine(num2);
            //        num2++;
            //}
            //     //List with Unique strings
            //     List<string>  stringList = new List<string>();
            //    stringList.Add("samantha");
            //     stringList.Add("aaron");
            //     bool Guessed = false;

            //do
            //{
            //     Console.WriteLine("select name");
            //    string AddName = Console.Readline();

            //     if (AddName == "aaron")
            //     {
            //        Console.WriteLine("you have selected: \t" + stringList[0]);
            //                break;

            //         }

            //    if (AddName == "samantha")
            //    {
            //        Console.WriteLine("you have selected: \t + stringList[1]);
            //        break;
            //    }

            //    else
            //    {
            //            Console.WriteLine("not on the list");
            //    }

            //     {
            //                while (!Guessed) ;
            //                Console.ReadLine();

            //     }

            // List of strings with two identitcal strings 
            List<string> name = new List<string>() { "Ash", "Ash" "john", "rob" };
            List<string> display = new List<string>();

            foreach (string item in name)
            {
                if (display.Contains(item))
                {
                    Console.WriteLine(item + "has appeared before!");
                }
                else
                {
                    Console.WriteLine(itme + "has not appeared before!");
                }
                display.Add(item);
            }
            Console.WriteLine("Ash :" + display.Count);
            Console.ReadLine();
           

            




    

    
        
       
        













    }
    }



}
