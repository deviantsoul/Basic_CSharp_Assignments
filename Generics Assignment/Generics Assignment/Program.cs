using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Black", "Pink", "Red", "White", "Yellow" };

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 1, 2, 3, 4, 5 };

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }

            foreach (int thing2 in employee1.Things)
            {
                Console.WriteLine(thing2);
                Console.ReadLine();
            }






        }
    }
}
