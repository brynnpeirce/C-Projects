using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparision
{
    class Program
    {
        static void Main()
        {
            //title
            Console.WriteLine("Anonymous Income Comparision Program");

            //person 1
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly rate: ");
            string hourlyRate = Console.ReadLine();
            int hRate = Convert.ToInt32(hourlyRate);
            Console.WriteLine("Hours worked per week: ");
            string weeklyHours = Console.ReadLine();
            int weekH = Convert.ToInt32(weeklyHours);

            //person 2
            Console.WriteLine("Person 2: ");
            Console.WriteLine("Hourly rate: ");
            string hourlyRate2 = Console.ReadLine();
            int hRate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week: ");
            string weeklyHours2 = Console.ReadLine();
            int weekH2 = Convert.ToInt32(weeklyHours2);

            //Annual salary of person 1
            int year = 52; //number of weeks in a year. 
            int annualSalary1 = hRate * weekH * year;
            Console.WriteLine("Person 1 Salary = $" + annualSalary1.ToString());
            Console.ReadLine();

            //Annual salary of person 2
            int annualSalary2 = hRate2 * weekH2 * year;
            Console.WriteLine("Person 2 Salary = $" + annualSalary2.ToString());
            Console.ReadLine();

            //Boolean statement
            bool salaryCompare = annualSalary1 > annualSalary2;
            Console.WriteLine("Does person 1 make more money than person 2? " + salaryCompare.ToString());
            Console.ReadLine();
            


        }
    }
}
