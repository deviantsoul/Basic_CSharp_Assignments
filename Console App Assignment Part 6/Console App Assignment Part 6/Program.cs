using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment_Part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>();
            intList.Add("Arthur");
            intList.Add("Arthur");
            intList.Add("Javier");
            intList.Add("Jack");
            intList.Add("Marshton");
            intList.Add("Abigail");
            intList.Add("Headache");            

            var myList = new List<string>();
            var duplicates = new List<string>();

            foreach (var name in intList)
            {
                if (!myList.Contains(name))
                    myList.Add(name);
                else
                    duplicates.Add(name);
            }

            // show list without duplicates 
            foreach (var name in myList)
            Console.WriteLine(name + " - first appearance.");

            // show duplicates list
            foreach (var name in duplicates)
                Console.WriteLine(name + " - already appeared.");

            Console.ReadLine();
        }
    }
}
