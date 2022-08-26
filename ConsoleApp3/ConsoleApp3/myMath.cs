using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class myMath
    {
        public void MathOp(int num) //void method
        {
            int Divide = num / 2;
            Console.WriteLine(Divide); //outputs integer
        }

        public void MathOp(string num) //overload method
        {
            string name = "Brynn";
            Console.WriteLine(name);
        }

        public void Me(out int myAge) //method with output parameters
        {
            myAge = 23;
        }

        //overload a method

        //static class
    }


}
