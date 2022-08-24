using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            theMath math = new theMath(); //instantiate class

            
            Console.WriteLine(math.MathOperation(5)); //calling method and passing in an integer
            Console.WriteLine(math.MathOperation(2.2m)); //calling method and passing in a decimal
            Console.WriteLine(math.MathOperation("6"));// calling method and passing in a string

            Console.ReadLine(); 
        }
    }
}
