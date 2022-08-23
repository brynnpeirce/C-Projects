using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    public static class integer
    {
        public Addition()
        {
            Random numGen = new Random();
            int randomNum = numGen.Next(0, 10);
            int AddSum = randomNum + Number1;
            Console.WriteLine(AddSum);
        }

        public Subtraction()
        {
            Random numGen = new Random();
            int randomNum = numGen.Next(0, 10);
            int SubtractSum = randomNum + Number1;
            Console.WriteLine(SubtractSum);
        }

        public Division()
        {
            Random numGen = new Random();
            int randomNum = numGen.Next(0, 10);
            int DivideSum = randomNum + Number1;
            Console.WriteLine(DivideSum);

        }
    }
}
