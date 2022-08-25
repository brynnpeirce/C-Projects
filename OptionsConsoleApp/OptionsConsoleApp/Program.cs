using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            myMath math = new myMath(); //instantiate class

            Console.WriteLine("Would you like to enter 2 numbers or 1 number?");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "1")
            {
                Console.WriteLine("Enter a number: "); //Asking user for input
                string userInput = Console.ReadLine();//saving input as a string
                int Num = Convert.ToInt32(userInput);//converting input to an int
                Console.WriteLine(math.MathOp(Num));
            }
            if (userAnswer == "2")
            {
                Console.WriteLine("Enter 1st number: "); //Asking user for input
                string userInput = Console.ReadLine();//saving input as a string
                int Num = Convert.ToInt32(userInput);//converting input to an int
                Console.WriteLine("Enter a 2nd number: ");
                string userInput2 = Console.ReadLine();
                int Num2 = Convert.ToInt32(userInput2);
                Console.WriteLine(math.MathOp(Num, Num2));
            }
            if (userAnswer != "1" && userAnswer != "2")
            {
                Console.WriteLine("Please enter 1 or 2");
            }

            Console.ReadLine();



            
        }
    }
}
