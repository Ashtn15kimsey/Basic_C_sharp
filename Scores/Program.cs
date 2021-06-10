using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter in yor First Name!");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back{ uName}. Today is { date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\ash\Desktop\Basic_C_sharp\Scores\StudetnScore.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
           
            double tScore = 0.0;
            
            Console.WriteLine("\nStudent Score: \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }
            double averageScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + "student score. \tAverage score:" + averageScore);

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();


        }
    }
}
