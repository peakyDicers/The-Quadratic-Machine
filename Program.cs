/* Ian Chui
 * Nov 13. 2015 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            //create variables.
            double aValue = 0;
            double bValue = 0;
            double cValue = 0;
            double answer1 = 0;
            double answer2 = 0;
            string optionInput = "a";
            string temp;

            //basic startup info.
            Console.Title = "Ian's Quadratic Machine";
            Console.SetWindowSize(50, 20);
            printMainScreen();

            //press z to skip main screen.
            while (optionInput != "z")
            {
                optionInput = Console.ReadLine();
                optionInput = optionInput.ToLower();
                Console.Clear();
                printMainScreen();
            }
            if (optionInput == "z")
                Console.Clear();

            //==============================================================================================
            // Solving the Quadratic.
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Enter your a, b and c values.");
                    //------------------------------------ 'a' variable
                    temp = Console.ReadLine();
                    if (isInteger(temp))
                        aValue = Convert.ToDouble(temp);
                    else
                    {
                        somethingWentWrong();
                        break;
                    }
                    //------------------------------------ 'b' variable
                    temp = Console.ReadLine();
                    if (isInteger(temp))
                        bValue = Convert.ToDouble(temp);
                    else
                    {
                        somethingWentWrong();
                        break;
                    }
                    //------------------------------------ 'c' variable
                    temp = Console.ReadLine();
                    if (isInteger(temp))
                        cValue = Convert.ToDouble(temp);
                    else
                    {
                        somethingWentWrong();
                        break;
                    }
                    //------------------------------------

                    if ((Math.Pow(bValue, 2) - 4 * aValue * cValue) >= 0) //if possible to square root.
                    {
                        answer1 = (-bValue + Math.Sqrt(Math.Pow(bValue, 2) - 4 * aValue * cValue)) / (2 * aValue);
                        answer2 = (-bValue - Math.Sqrt(Math.Pow(bValue, 2) - 4 * aValue * cValue)) / (2 * aValue);
                        Console.WriteLine("x = " + answer1 + " and x = " + answer2);
                    }
                    else
                        Console.WriteLine("There are no x-intercepts here kiddo.");

                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
        static void printMainScreen() //prints main screen.
        {
            Console.WriteLine("\n \n \n \n \n \n");
            Console.WriteLine("      =====================================");
            Console.WriteLine("      =       The Quadratic Machine       =");
            Console.WriteLine("      =====================================");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("              Do sum quadratics [z]  ");
        }
        static void somethingWentWrong() //what happens when user inputs invalid key for quadratic formula.
        {
            Console.WriteLine("Something went wrong, try again.");
            Console.ReadKey();
            Console.Clear();
        }
        private static bool isInteger(string temp) //checks whether integer is valid or not. 
        {
            try
            {
                Convert.ToInt32(temp); //if integer, return true
                return true;
            }
            catch (FormatException)    //if non-integer, return false
            {
                return false;
            }
        }
    }
}
