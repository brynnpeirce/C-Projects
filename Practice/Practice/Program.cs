using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isGuessed = false;

            do
            {
                Console.WriteLine("Guess what letter my name starts with!");
                string letter = Console.ReadLine();

                switch (letter)
                {
                    case "X":
                        Console.WriteLine("you Guess X. Try again");
                        Console.WriteLine("Guess again!");
                        Console.ReadLine();
                        break;
                    case "L":
                        Console.WriteLine("You guessed L. Try again");
                        Console.WriteLine("Guess again!");
                        Console.ReadLine();
                        break;
                    case "M":
                        Console.WriteLine("You guessed M. Try again");
                        Console.WriteLine("Guess again!");
                        Console.ReadLine();
                        break;
                    case "B":
                        Console.WriteLine("you guessed B. Correct!");
                        isGuessed = true;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong");
                        Console.WriteLine("Guess again!");
                        Console.ReadLine();
                        break;
                }

            }
            while (!isGuessed);

            Console.Read();

        }
    }
}
