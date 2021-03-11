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
            intList.Add("it's me.");
            intList.Add("I was wondering ");
            intList.Add("if after all these years ");
            intList.Add("you'd like to meet. ");
            intList.Add("To go over everything. ");
            intList.Add("They say that time's ");

            Console.WriteLine("Add any text to a lyric.");
            string[] userinput = { };
            userinput[0] = Console.ReadLine();
            Console.WriteLine(userinput[0]);
            
        }
    }
}
