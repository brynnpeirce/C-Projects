﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People2
{
    class Program
    {
        public static void Main(string[] args)
        {
            IQuittable quit = new Employee(); //polymorphism
            quit.Quit();  //call method
            Employee name = new Employee();
            name.FirstName = "Sample";
            name.LastName = "Student";
            name.Id = 13;
            name.SayName();
            Console.ReadLine();

        }
    }
}
