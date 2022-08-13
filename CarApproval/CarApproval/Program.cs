using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApproval
{
    class Program
    {
        static void Main()
        {   //intro
            Console.WriteLine("Car Insurance Approval:");

            //questions for the user
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            int A = Convert.ToInt32(Age); //converted to an integer
            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine(); 
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int T = Convert.ToInt32(tickets); //converted to an integer

            bool Qualified = (A >= 15 && DUI == "false" && T < 3); //boolean using &&
            Console.WriteLine("Qualified? : " + Qualified); //will output 'true' or 'false' based on users answers
            Console.ReadLine();




        }
    }
}
