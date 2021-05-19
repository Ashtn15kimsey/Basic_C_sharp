using System;

namespace myConsoleProject.cs_
{
    class Program
    {
        private const string Value = "Hello, World";

        static void Main()
        {
            Console.WriteLine("What is Your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();
        }
    }
}
