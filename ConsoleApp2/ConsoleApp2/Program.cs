using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            myMath math = new myMath(); //instantiate class myMath
           
            math.MathOp(num1 : 9, num2: 10); // calling method with 2 parameters
            Console.ReadLine();

        }
    }
}
