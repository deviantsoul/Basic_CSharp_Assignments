using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Subtraction");
            Console.WriteLine("Multiplication");
            Console.WriteLine("Please choose from the following on what math operations you would like to proceed:");                        
            
            string userInput = Console.ReadLine();
            string answer = userInput.ToLower();

            if (answer == "addition")
                {
                    Console.WriteLine("Enter first number to add: ");
                    int input1 = Convert.ToInt32(Console.ReadLine());                    
                    Console.WriteLine("Now, put the second number to add: ");
                    int input2 = Convert.ToInt32(Console.ReadLine());                    
                    SimpleMath num1 = new SimpleMath();
                    Console.WriteLine("The answer is " + num1.plusMethodInt(input1, input2));
                    Console.ReadLine();
                    return;
                }
            
            if (answer == "subtraction")
                {
                    Console.WriteLine("Enter first number to subtract: ");
                    int input1 = Convert.ToInt32(Console.ReadLine());                   
                    Console.WriteLine("Now, put the second number to subtract: ");
                    int input2 = Convert.ToInt32(Console.ReadLine());                    
                    SimpleMath num1 = new SimpleMath();
                    Console.WriteLine("The answer is " + num1.minusMethodInt(input1, input2));
                    Console.ReadLine();
                    return;
                }
            if (answer == "multiplication")
                {
                    Console.WriteLine("Enter first number to multiply: ");
                    int input1 = Convert.ToInt32(Console.ReadLine());                    
                    Console.WriteLine("Now, put the second number to multiply: ");
                    int input2 = Convert.ToInt32(Console.ReadLine());                    
                    SimpleMath num1 = new SimpleMath();
                    Console.WriteLine("The answer is " + num1.multiplyMethodInt(input1, input2));
                    Console.ReadLine();
                    return;
                }

            else
                {
                    Console.WriteLine("I didn't ask for other output, did I? Or check your spelling and learn to follow! sigh T__T Bye.");
                    Console.ReadLine();
                    return;
                }

            

        }
    }
}
