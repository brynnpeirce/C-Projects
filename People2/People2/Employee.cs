using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People2
{
    public class Employee : Person, IQuittable //Employee class inherits Person class and IQuitable interface
    {
        public int Id { get; set; }
         
        public void EmployeeInfo()
        {
            Console.WriteLine(FirstName + " " + Id);
        }

        public void Quit()
        {
            Console.WriteLine("I QUIT!");
        }
    }
}
