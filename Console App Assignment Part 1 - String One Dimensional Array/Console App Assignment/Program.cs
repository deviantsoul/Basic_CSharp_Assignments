using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>(8);
            intList.Add("Hello, ");
            intList.Add("It's me.");
            intList.Add("I was wondering ");
            intList.Add("if after all these years ");
            intList.Add("you'd like to meet. ");
            intList.Add("To go over everything. ");
            intList.Add("They say that time's ");

            Console.WriteLine("The lyrics so far.");
            foreach (string s in intList)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
            Console.WriteLine("Add any text to a lyric. Type stop or quit if done.");
            string input = "";

            while ((input = Console.ReadLine()) != string.Empty)
            {
                if (input == "stop" || input == "quit")
                {
                    Console.WriteLine("Stopping, displaying results.");
                    break;
                }

                Console.WriteLine("Adding: " + input);
                intList.Add(input);
            }

            Console.WriteLine("");
            Console.WriteLine("Displaying all words.");
            foreach(String s in intList)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
