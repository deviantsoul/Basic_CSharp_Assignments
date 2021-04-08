using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee Entry = new Employee();

            
            Entry.FirstName = "Sample";
            Entry.LastName = "Student";

            
            Entry.SayName();
            Console.ReadLine();
        }
    }
}
