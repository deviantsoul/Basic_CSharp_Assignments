using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialize employee object
            Employee Entry = new Employee();

            //instantiate employee with sample name
            Entry.FirstName = "Sample";
            Entry.LastName = "Student";

            //calling superclass method sayname()
            Entry.SayName();
            Console.ReadLine();
        }
    }
}
