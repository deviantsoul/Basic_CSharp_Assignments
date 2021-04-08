using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calculating...");
            Console.ReadLine();

            Console.WriteLine("Result is: ");
            Console.ReadLine();
            SimpleMath Addin = new SimpleMath();
            Addin.myDivide(input);
            Console.ReadLine();

            Console.WriteLine("Please enter another number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("And another number: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calculating...");
            Console.ReadLine();

            Console.WriteLine("Result is: ");
            Console.ReadLine();
           
            Addin.myDivide(input2, input3);
            Console.ReadLine();

            Console.WriteLine("Now for output parameters assignment.");
            Console.ReadLine();

            int a = 85;

            Console.WriteLine("Before method call, value of a : {0}", a);

            //calling the output parameters sample
            Addin.myTest(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();


            Console.WriteLine("Enter a number for static assignment: ");
            int input4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parsing the static class...");
            Console.ReadLine();

            //Calling the static class with static method inside it
            StaticClass.SubtractMe(input4);

            Console.ReadLine();


        }

    }
}
