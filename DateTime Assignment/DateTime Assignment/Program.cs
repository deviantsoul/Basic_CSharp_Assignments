using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime_Assignment
{
    class Program
    {        
        static void Main(string[] args)
        {            
            Console.WriteLine("Today is " + DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Please enter a number: ");

            int input = Convert.ToInt32(Console.ReadLine());
            string hourOnly = DateTime.Now.ToString("HH");

            string text = Convert.ToString(input);
            File.WriteAllText("C:\\Users\\ucabh\\Desktop\\Basic_CSharp_Assignments\\Logs\\log.txt", text);

            string readText = File.ReadAllText("C:\\Users\\ucabh\\Desktop\\Basic_CSharp_Assignments\\Logs\\log.txt");
            Console.WriteLine("You typed: " + readText + " @ " + hourOnly + " o`clock.");
            Console.ReadLine();
        }
    }
}
