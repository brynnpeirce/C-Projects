using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee name = new Employee(); //instantiate Employee class
            name.FirstName = "Sample";
            name.LastName = "Student";
            name.SayName(); //call method
            Console.ReadLine();


        }
    }
}
