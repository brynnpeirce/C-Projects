namespace OptionsConsoleApp
{
    public class myMath
    {
        public int MathOp( int num1, int num2 = 1) //two parameters, num2 is optional, default num2 is 1
        {
               int addMath = num1 + num2;
                return addMath;
        }
    }
}