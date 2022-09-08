using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTImes

{
    class Program
    {
        static void Main(string[] args)
        {
            var Current = DateTime.Now;
            Console.WriteLine(Current); //prints the current date and time to the console
            
             

            Console.WriteLine("Pick a number between 1-10"); //ask user for a number X
            String UserNumber = Console.ReadLine();
            int Number = Convert.ToInt32(UserNumber); //Converts string to integer

            var XHours = Current.AddHours(Number); //Takes the current time and adds the number of hours the user gave
            Console.WriteLine(XHours);//prints to the console the time it will be in X hours
            Console.ReadLine();
        }
    }
}
