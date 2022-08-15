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

           

            
            bool colorguess = false;

            while (!colorguess)
            {
                Console.WriteLine("Guess my favorite color!");
                string color = Console.ReadLine();
                switch (color)
                {
                    case "Red":
                        Console.WriteLine("Nope! Red is not my favorite color. Try again!");
                        Console.ReadLine();
                        break;
                    case "Orange":
                        Console.WriteLine("Nope! Orange is not my favorite color. Try again!");
                        Console.ReadLine();
                        break;
                    case "Yellow":
                        Console.WriteLine("Nope! Yellow is not my favorite color. Try again!");
                        Console.ReadLine();
                        break;
                    case "Green":
                        Console.WriteLine("Nope! Green is not my favorite color. Try again!");
                        Console.ReadLine();
                        break;
                    case "Blue":
                        Console.WriteLine("Nope! Blue is not my favorite color. Try again!");
                        Console.ReadLine();
                        break;
                    case "Purple":
                        colorguess = true;
                        Console.WriteLine("Yes! I love Purple");
                        Console.ReadLine();
                        break;
            

                }
                Console.ReadLine();
            }

        }
    }
}
