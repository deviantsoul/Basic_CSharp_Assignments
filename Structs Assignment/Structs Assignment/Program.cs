using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number();
            myNumber.Amount = 2.123m;

            Console.WriteLine(myNumber.Amount);

            Console.ReadLine();
        }
    }
}
