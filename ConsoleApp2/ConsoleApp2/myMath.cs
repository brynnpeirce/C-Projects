using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class myMath
    {
        public void MathOp(int num1,int num2) //a void method that takes in 2 parameters
        {
            int AddMath = num1 + 100; //math equations on first parameter
            Console.WriteLine(num1 + " + 100" + " = " + AddMath); //output equation of first parameter
            Console.WriteLine(num2); //output of parameter 2

        }
    }
}
