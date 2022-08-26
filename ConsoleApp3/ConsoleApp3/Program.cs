using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            myMath math = new myMath(); //instantiate class

            math.Me(out int myAge);
            
            Console.WriteLine("Enter a number: ");
            string userNum = Console.ReadLine();
            int Num = Convert.ToInt32(userNum);

            math.MathOp(Num);
        }
    }
}
