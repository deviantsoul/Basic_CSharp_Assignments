using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_3
{
    class Program
    {       
        static void Main(string[] args)
        {
            myVoid n = new myVoid();
            n.Sample();
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();

            n.Sample(x: 1 + 1, y: 3);
            Console.ReadLine();
            
        }

        
    }
}
