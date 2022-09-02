using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;

        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;
        }

    }
}
