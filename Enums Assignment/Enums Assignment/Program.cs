using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            try
            {
                Console.WriteLine("Please enter the current name of the day.");
                string input = Console.ReadLine();
                string test = input.ToUpper();

                OneWeek.DaysOfTheWeek day;

                if (Enum.TryParse<OneWeek.DaysOfTheWeek>(test, out day))
                {
                    Console.WriteLine("You are right! Today is  " + test);
                }

                else
                {
                    throw new OverflowException();
                }
         

            }

            catch (OverflowException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                
                
            }

            Console.ReadLine();
            return;
                
        }
    }
}
