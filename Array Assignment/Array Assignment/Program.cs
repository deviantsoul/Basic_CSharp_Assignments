using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[5];
            stringArray[0] = "Arthur";
            stringArray[1] = "Morgan";
            stringArray[2] = "Charles";
            stringArray[3] = "Dutch";
            stringArray[4] = "Javier";
            
           
            Console.WriteLine("Select an index you want to see: (0-4 only)");
            //get user's input by parse
            int input = int.Parse(Console.ReadLine());
            //searching the index with user's input
            Console.WriteLine(stringArray[input]);
            Console.ReadLine();

            int[] arr = new int[5];
            arr[0] = 4;
            arr[1] = 6;
            arr[2] = 8;
            arr[3] = 10;
            arr[4] = 12;

            Console.WriteLine("Enter an index position you want to see: (0-4 only)");
            //get user's input by parse
            int input2 = int.Parse(Console.ReadLine());
            //searching the index with user's input
            Console.WriteLine(arr[input2]);


            //Add in a message that displays when user selects an index that doesn't exist. This sample uses -1 as a result
            int[] grades = { 50, 75, 80, 90, 100 };

            Console.WriteLine("Please enter the grade you want to search: ");
            int input3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Array.IndexOf(grades, input3));
            Console.ReadLine();

            //Another method is to use the bool
            bool found = false;
            Console.WriteLine("Another method: Please enter the grade you want to search: ");
            int input4 = int.Parse(Console.ReadLine());
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == input4)
                {
                    Console.WriteLine("The index is at position:" + Array.IndexOf(grades, input4));
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Not found.");
            }

            Console.ReadLine();

            //Assignment where to make a list and search the index.
            List<string> intList = new List<string>();
            intList.Add("Hello.");
            intList.Add("Hansen");
            intList.Add("Arthur");
            intList.Add("Dutch");
            intList.Add("Javier");
            intList.Add("John");
            intList.Add("Marshton");
            intList.Add("Abigail");

            Console.WriteLine("Enter an index position you want to see: (0-7 only)");
            int input5 = int.Parse(Console.ReadLine());
            Console.WriteLine(intList[input5]);
            Console.ReadLine();

        }
    }
}
