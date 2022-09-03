using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        enum Week
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it today?");
            string day = Console.ReadLine();
            Week today;
            try
            {
                today = (Week)Enum.Parse(typeof(Week), day) ;
                Console.WriteLine(today);
                 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
        }
       
    }
}
