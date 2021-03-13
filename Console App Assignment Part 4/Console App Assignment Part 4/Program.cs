using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment_Part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>();
            intList.Add("Arthur");
            intList.Add("Abigail");
            intList.Add("Dutch");
            intList.Add("Lenny");
            intList.Add("Javier");
            intList.Add("Sadie");
            intList.Add("Charles");
            intList.Add("Bill");
            intList.Add("Hosea");
            intList.Add("Jack");
            intList.Add("John");
            intList.Add("Josiah");
            intList.Add("Karen");
            intList.Add("Kieran");
            intList.Add("Leopold");
            intList.Add("Mary-Beth");
            intList.Add("Micah");
            intList.Add("Molly");
            intList.Add("Pearson");
            intList.Add("Swanson");
            intList.Add("Sean");
            intList.Add("Susan");
            intList.Add("Tilly");
            intList.Add("Uncle");

            bool found = false;
            Console.WriteLine("Name search for Van der Linde Gang");
            string input = Console.ReadLine();
            for ( int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == input)
                {
                    Console.WriteLine("The index is at position: " + intList.IndexOf(input));
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Not found.");
            }

            Console.ReadLine();
            
        }
    }
}
