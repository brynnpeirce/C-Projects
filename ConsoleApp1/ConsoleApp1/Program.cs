using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Numbers = new List<int>() { 22, 44, 76, 98, 100 };
                Console.WriteLine("Pick a number: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int number in Numbers)
                {
                    Console.WriteLine(number / userNumber);
                }
                Console.ReadLine();
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
