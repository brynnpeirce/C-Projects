using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName() //method combines first name and last name
        {
            string FullName = FirstName + LastName;
            Console.WriteLine("Name: " + FullName);
       
        }
    }
}
