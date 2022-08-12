using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {   //First line welcoming user to page
            Console.WriteLine("The Tech Academy \nStudent Daily Report:");
       

            //question 1 = string
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //question 2 = string
            Console.WriteLine("What course are you on?");
            string techCourse = Console.ReadLine();


            // question 3 = int
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);

            //question 4 = boolean
            Console.WriteLine("Do you need help with anything? \nPlease answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            bool nHelp = Convert.ToBoolean(needHelp);

            //question 5 = string
            Console.WriteLine("Were there any positive experiences you'd like to share? \nPlease give specifics.");
            string postiveX = Console.ReadLine();

            //question 6 = int
            Console.WriteLine("How many house did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursS = Convert.ToInt32(hoursStudied);

            //ending statement
            Console.WriteLine("Thank your for your answers.\nAn instructor will respond shortly.\nHave a great day!");
            Console.ReadLine();


           


        }
    }
}
