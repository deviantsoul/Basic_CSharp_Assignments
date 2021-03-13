using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment_Part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>();
            intList.Add("Hosea");
            intList.Add("Hosea");
            intList.Add("Arthur");
            intList.Add("Dutch");
            intList.Add("Javier");
            intList.Add("Arthur");
            intList.Add("Marshton");
            intList.Add("Abigail");
            intList.Add("Jack");
            intList.Add("Charles");
            intList.Add("Charles");
            intList.Add("Lenny");
            intList.Add("Abigail");
            
            Console.WriteLine("Enter name to search for duplicates.");
            string input = Console.ReadLine();

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i].Equals(input))
                {
                    Console.WriteLine(i);
                }                
            }

            if (intList.Contains(input))
            {
                Console.WriteLine("Those are the index/indices of " + input + ".");
            }

            else
                Console.WriteLine("I guess you're out of luck. That bandit is not here.");

            Console.ReadLine();
        }
    }
}
