using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pick a Number : ");
            string UserNumber = Console.ReadLine();
            int Number1 = Convert.ToInt32(UserNumber);


            int result1 = MyMath.Addition(Number1);
            int result2 = MyMath.Subtraction(Number1);
            int result3 = MyMath.Division(Number1);
            Console.WriteLine(Number1 + " + " + "5" + " = " + result1);
            Console.WriteLine(Number1 + " - " + "5" + " = " + result2);
            Console.WriteLine(Number1 + " / " + "5" + " = " + result3);


            Console.ReadLine();

        }

    }
}
