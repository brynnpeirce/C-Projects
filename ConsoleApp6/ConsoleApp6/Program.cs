using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {   //Assignment 1 list: string colors
            string[] Colors = { "red", "orange", "yellow", "green", "blue", "purple" };


            Console.WriteLine("Enter statement: "); //requesting user input
            string statement = Console.ReadLine(); //statement = user input

            for (int i = 0; i < Colors.Length; i++)  //for loop that will iterate through color list
            {
                Console.WriteLine(Colors[i] + " " + statement); //list item plus user statement
            }
            Console.ReadLine();

            Console.WriteLine("Full Array: ");
            Console.ReadLine();

            for (int x = 0; x < Colors.Length; x++) //will iterate through each item in the list
            {
                Console.WriteLine(Colors[x]); //prints out each item in list 
            }
            Console.ReadLine();

            //assignment 2 
            //Created an infinite loop: continues to print 9 until program is terminated. 
            int[] FavNumbers = { 4, 9, 13, 23, 30, 33, 100 };

            for (int i = 0; i > 100;) // fixed by changing i < 100 to i > 100. 
            {
                Console.WriteLine(FavNumbers[1]); //no longer infinite, but it won't print anything because index 1 will never be greater than 100. 
            }
            Console.ReadLine();

            //assignmet 3 
            // loop with a < operator
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.ReadLine();

            // loop with <= operator
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.ReadLine();

            //assignment 4
            // string list
            List<string> uniqueItems = new List<string>()
            {
                "New York", "hello world", "5", "people"
            };

            Console.WriteLine("Enter item to search for: "); //requesting user for input
            string search = Console.ReadLine(); // saved user input in "search"

            foreach (string item in uniqueItems) // loop that will iterate through each index
            {
                if (search == "New York")
                {
                    Console.WriteLine(search + " is in the list! Its at index " + uniqueItems.IndexOf(search)); //outputs index of item choosen by user
                    break; //ends loop if true
                }
                if (search == "hello world")
                {
                    Console.WriteLine(search + " is in the list! Its at index " + uniqueItems.IndexOf(search));
                    break;
                }
                if (search == "5")
                {
                    Console.WriteLine(search + " is in the list! Its at index " + uniqueItems.IndexOf(search));
                    break;
                }
                if (search == "people")
                {
                    Console.WriteLine(search + " is in the list! Its at index " + uniqueItems.IndexOf(search));
                    break;
                }
                if (search != "New York" && search != "hello world" && search != "5" && search != "people") //if user enters item not in the list
                {
                    Console.WriteLine("That item is not in the list");
                    break;
                }
            }
            Console.ReadLine();

            //assignment 5
            // string list with 2 identical strings
            List<string> fruits = new List<string>()
            {
                "apple", "cherry", "apple", "pineapple"
            };

            Console.WriteLine("Enter item to search for: ");
            string UserSearch = Console.ReadLine();

            foreach (string fruit in fruits)
            {
                if (UserSearch == "apple" || UserSearch == "pineapple" || UserSearch == "cherry")
                {
                    Console.WriteLine(UserSearch + " is in the list! Its at index " + fruits.IndexOf(UserSearch)); //outputs index of item choosen by user
                }

                if (UserSearch != "apple" && UserSearch != "pineapple" && UserSearch != "cherry") //if user enters item not in the list
                {
                    Console.WriteLine(UserSearch + " is not in the list");
               }  

            }
            Console.ReadLine();

            //assignment 6
            //string list including 2 identical strings
            List<string> Places = new List<string>() { "New York", "Washington", "Oregon", "New York" };
            List<string> Places2 = new List<string>() ; //second string list empty 

            foreach (string place in Places) //for each index in Places list
            {
               if(Places2.Contains(place))  // checks Places vs Places2 if place has a match
                {
                    Console.WriteLine(place + " has appeared before."); 
                }
               else
                {
                    Console.WriteLine(place + " has not appeared before.");
                }
                Places2.Add(place); 
            }
            Console.ReadLine();
        }



    }
}
