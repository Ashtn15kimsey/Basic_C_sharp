using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmission.Asg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome that's always present when the program is runnin, meaning you don't need to press enter to have it pop up.
            string Welcome = ("The Tech Academy \nStudent Daily Report:");
            Console.WriteLine(Welcome);
            Console.ReadLine();

            string username = ("what is your name?");
            Console.WriteLine(username);
            Console.ReadLine();

            string courseNumber = ("what course are you on?");
            Console.WriteLine(courseNumber);
            Console.ReadLine();

            Console.WriteLine("what page number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help anything ? please answer "true" or "false");

            string experience = ("Were there any postive expereinces you'd like to share? please give specifics.");
            Console.WriteLine(experience);
            Console.ReadLine();

            string feedback = ("s there any other feedback you’d like to provide? Please be specific");
            Console.WriteLine(feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            byte HoursStuduied = Convert.ToByte(Console.ReadLine());

            // This code lets the the user that their information has been taken and will be reviewd //
            string ThankYou = ("Thank you for the your answer. An Instructor will respond to this shortly. Have a good day!");
            Console.WriteLine(ThankYou);
            Console.ReadLine();


        }
    }
}
