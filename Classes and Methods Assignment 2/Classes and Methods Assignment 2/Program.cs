using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Classes_and_Methods_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1, input2;
            int result;
            SimpleMath num1 = new SimpleMath();

            Console.WriteLine("Please enter your first number: ");
            if (!int.TryParse(Console.ReadLine(), out input1))
                throw new ArgumentException("No valid input.");                

            Console.WriteLine("OPTIONAL: Enter your second number: ");
            if (int.TryParse(Console.ReadLine(), out input2))
                Console.WriteLine("The answer is " + num1.plusMethod(input1, input2));
            else
                Console.WriteLine("Result is: " + num1.plusMethod(input1));
            
            Console.ReadLine();
        }
    }
}
