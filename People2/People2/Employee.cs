using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People2
{
    public class Employee : Person
    {
        public int Id { get; set; }
         
        public void EmployeeInfo()
        {
            Console.WriteLine(FirstName + " " + Id);
        }
    }
}
