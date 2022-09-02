using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "Brynn";
            emp1.LastName = "Jackson";

            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.FirstName = "Macgregor";
            emp2.LastName = "Peirce";

            if (emp1 == emp2)
            {
                Console.WriteLine("Employee 1 is the same as Employee 2");
            }
            else
            {
                Console.WriteLine("Employee 1 is not the same as Employee 2");
            }
            Console.ReadLine();
        }
    }
}
