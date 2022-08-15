using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {   // welcome message
            Console.WriteLine("Welcome to Package Express.\n Please follow the instructions below.");
            Console.ReadLine();

            //user prompted to enter package weight
            //String input converted to decimal for later use in calculations. 
            Console.WriteLine("Please enter package weight:");
            string packageWeight = Console.ReadLine();
            decimal Weight = Convert.ToDecimal(packageWeight);

            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.\n Have a nice day!");
                return;
               
            }
            else
            {
                Console.WriteLine("Your package weight passes, lets continue....");
            }

            //User  prompted to enter width, height and length
            // string converted to decimal for later use in calculations.
            Console.WriteLine("Please enter package width: ");
            string packageWidth = Console.ReadLine();
            decimal Width = Convert.ToDecimal(packageWidth);
            Console.WriteLine("Please enter package height: ");
            string packageHeight = Console.ReadLine();
            decimal Height = Convert.ToDecimal(packageHeight);
            Console.WriteLine("Please enter package length: ");
            string packageLength = Console.ReadLine();
            decimal Length = Convert.ToDecimal(packageLength);

            if (Width + Height + Length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                decimal result = ((Height * Length * Width) * Weight) / 100;
                Console.WriteLine("Your estimated total for shipping this\n this package is: $" + result + "\n Thank you!");
            }

            Console.ReadLine();
           











        }
    }
}
