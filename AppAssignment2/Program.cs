﻿using System;
using System.Collections.Generic;


namespace AppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            /* do loop execution */
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a = a + 1;
            }
            while (a < 30);
            Console.ReadLine();

        }
    }
}
