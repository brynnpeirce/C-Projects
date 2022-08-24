using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp
{
    public class theMath
    {
        public int MathOperation(int Num)
        {
            int addMath = Num + 2; //create a math operation w/ integer and return as int
            return addMath;
        }

        public int MathOperation(decimal Num)
        {
            decimal Math = Num - 2;//takes a decimal, creates a different math operation, return as int
            int subtractMath = Convert.ToInt32(Math);
            return subtractMath;
        }

        public int MathOperation(string Num)
        {
            int Math = Convert.ToInt32(Num);
            int multiplyMath = Math * 2;  //Convert string to integer, create different math operation, return as int
            return multiplyMath;
        }
    }
}
