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
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee
            {
                FirstName = "Bob",
                LastName = "Stevens",
                Id = 1
            });
            employees.Add(new Employee
            {
                FirstName = "Joe",
                LastName = "Jackson",
                Id = 2
            });
            employees.Add(new Employee
            {
                FirstName = "Macgregor",
                LastName = "Peirce",
                Id = 3
            });
            employees.Add(new Employee
            {
                FirstName = "Amy",
                LastName = "Smith",
                Id = 4
            });
            employees.Add(new Employee
            {
                FirstName = "Sydney",
                LastName = "Spear",
                Id = 5
            });
            employees.Add(new Employee
            {
                FirstName = "Koda",
                LastName = "James",
                Id = 6
            });
            employees.Add(new Employee
            {
                FirstName = "David",
                LastName = "Kunzler",
                Id = 7
            });
            employees.Add(new Employee
            {
                FirstName = "Ruby",
                LastName = "Jefferson",
                Id = 8
            });
            employees.Add(new Employee
            {
                FirstName = "Brynn",
                LastName = "Moss",
                Id = 9
            });
            employees.Add(new Employee
            {
                FirstName = "Reagen",
                LastName = "Short",
                Id = 10
            });

            List<Employee> newList = employees.Where(x => x.FirstName.Equals("Joe")).ToList();
            foreach(var x in newList)
            {
                Console.WriteLine(newList);
            }
            List<Employee> newList2 = employees.Where(x => x.Id > 5).ToList();
            foreach (var x in newList2)
            {
                Console.WriteLine(newList2);
            }


            Console.ReadLine();

            
        }
    }
}
