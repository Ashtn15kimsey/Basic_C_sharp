using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //example 1
            //if (1 == 7)
            {
               // Console.WriteLine("1 is equal to 1");
                //Console.ReadLine();
            }
            //else
            {
                // Console.WriteLine("1 does not equal 1");
                //Console.ReadLine();


                //example 2
                //string name = "Ash";
                //if (name == "Ash") 
                {
                    //Console.WriteLine("your name is Ash");
                    //Console.ReadLine();
                }
                //else
                {
                    //Console.WriteLine("your name is not ash");
                    //Console.ReadLine();
                }

                //exaple 3

                // string name = "Ash";
                //if (name != "adam")
                {
                    //Console.WriteLine("your name is Ash");
                    //Console.ReadLine();
                }
                //else if (name == "Tom")
                {
                    //Console.WriteLine("your name is not ash");
                    //Console.ReadLine();
                }
                //else
                {
                    //Console.WriteLine("your name is not ash. your name is not tom");
                    //Console.ReadLine();
                }

                //example 4
                //if (2 != 3)
                {
                    //Console.WriteLine("you meet the requirement");
                    //Console.ReadLine();
                }
                //else
                {
                    //Console.WriteLine("you don't meet the requirement");
                    //Console.ReadLine();
                }


                //greater than operator
                //int num1 = 18;
                //int num2 = 15;
                //if (num1 > num2)
                {
                    //Console.WriteLine("the first number is larger");
                    //Console.ReadLine();
                }
                //else
                {
                    //Console.WriteLine("the second number is larger");
                    //Console.ReadLine();
                }
                // lesser than operator
                //int age = 20;
                //if (age < 23)
                {
                    //Console.WriteLine("You may not purchase alchol");
                    //Console.ReadLine();

                }
                //else
                {
                    //Console.WriteLine("That will be $17.56");
                    //Console.ReadLine();
                }
                // greater than or equal to operator
                //int age = 20;
                //if (age >= 25)
                {
                    //Console.WriteLine("you may run a car from us");
                    //Console.ReadLine();
                }
                //else
                {
                    //Console.WriteLine("you may not rent car from us");
                    //Console.ReadLine();
                }

                // being sepcific within a statement
                //int packageWeight = 30;
                //int packageLength = 25;
                //if (packageWeight > 40 && packageLength > 20)
                {
                    //Console.WriteLine("The package is too big to shimp.");
                    //Console.ReadLine();
                }

                // if you to to see if one expression is true.

                //string role = "admin";
                //if (role == "admin" || role == "administrator")
                {
                    //Console.WriteLine("you may have access");
                    //Console.ReadLine();
                        
                }

                int num1 = 23;
                int num2 = 30;

                string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
                Console.WriteLine(result);
                Console.ReadLine();

               
                

                

                



            }
                





        }
    }
}
