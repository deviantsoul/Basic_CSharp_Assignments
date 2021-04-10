using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there 007, this is Q. What number are you reporting right now: ");
            int input = Convert.ToInt32(Console.ReadLine());

            string text = Convert.ToString(input);
            File.WriteAllText("C:\\Users\\ucabh\\Desktop\\Basic_CSharp_Assignments\\Logs\\log.txt", text);

                       
            string readText = File.ReadAllText("C:\\Users\\ucabh\\Desktop\\Basic_CSharp_Assignments\\Logs\\log.txt");
            Console.WriteLine("Here is your report: " + readText);
            Console.ReadLine();

            Console.WriteLine("Thanks. This will explose should you or should you not accept this feedback. Bye bye.");
            Console.ReadLine();
        }
    }
}
