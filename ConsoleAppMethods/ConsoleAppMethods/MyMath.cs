using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    public static class MyMath
    {
        public static int Addition(int userInput)
        {

            int AddSum = userInput + 5;
            return AddSum;

        }

        public static int Subtraction(int userInput)
        {
            int SubtractSum = userInput - 5;
            return SubtractSum;
        }

        public static int Division(int userInput)
        {
            int DivideSum = userInput / 5;
            return DivideSum;

        }
    }
}
