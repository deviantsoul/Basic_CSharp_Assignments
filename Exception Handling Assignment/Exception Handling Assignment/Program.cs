using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?: ");
                int input = Convert.ToInt32(Console.ReadLine());
                int birthYear = input - DateTime.Now.Year;

                if (input >= 1)
                {
                    Console.WriteLine("Your date of birth is: " + Math.Abs(birthYear));                                       
                }

                else
                {
                    throw new ArgumentException();
                }
                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a POSITIVE and a non ZERO value.");
            }
            catch (Exception)
            {
                Console.WriteLine("Come on, use your common sense. Age is it really that hard?");
            }

            Console.ReadLine();
            return;
            
        }
    }
}
