using System;
using System.Collections.Generic;


namespace Arrays_Lists
{
    class Program
    {
        static void Main()
        {
            // List of numbers
            List<string> stringList = new List<string>();
            stringList.Add("hello");
            stringList.Add("hi");
            stringList.Add("hey");

            // String Array
            string[] stringArray1 = { "Brynn", "Macgregor", "Ruby", "Jackson", "Mac", "Raegan" };

            // Number array
            int[] numArray2 = { 1, 2, 3, 4, 5, 6 };

            //array 1
            // requesting an index number from the user
            // Converting string intput to a int output
            // displaying index from array user requested
            Console.WriteLine("Select an index from array 1: ");
            string index = Console.ReadLine();
            int i = Convert.ToInt32(index);

            if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5)
            {
                Console.WriteLine(stringArray1[i]);
            }
            else
            {
                Console.WriteLine("Sorry that index does not exist. \n Choose a number between 0-5");
            }

            //array 2
            // requesting an index number from the user
            // Converting string intput to a int output
            // displaying index from array user requested
            Console.WriteLine("Select an index from array 2: ");
            string index2 = Console.ReadLine();
            int i2 = Convert.ToInt32(index2);

            if (i2 == 0 || i2 == 1 || i2 == 2 || i2 == 3 || i2 == 4 || i2 == 5)
            { 
                Console.WriteLine(numArray2[i2]);
            }
            else
            {
                Console.WriteLine("Sorry that index does not exist. \n Choose a number between 0-5");
            }
           

            //List
            // requesting an index number from the user
            // Converting string intput to a int output
            // displaying index from array user requested
            Console.WriteLine("Select an index from List: ");
            string index3 = Console.ReadLine();
            int i3 = Convert.ToInt32(index3);

            if (i3 == 0 || i3 == 1 || i3 == 2)
            {
                Console.WriteLine(stringList[i3]);
            }
            else
            {
                Console.WriteLine("Sorry that index does not exist. \n Choose a number between 0-2");
            }
            

            Console.ReadLine();

        }




    }
}
