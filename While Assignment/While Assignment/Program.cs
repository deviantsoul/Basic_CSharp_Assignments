using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genNumber = new Random();
            int numberofTries = 0;
            int numberofAttempts = 0;

            while (numberofAttempts != 10)
            {
                numberofAttempts = genNumber.Next(0, 11);
                Console.WriteLine("You rolled: " + numberofAttempts + ".");
                numberofTries++;
            }

            Console.WriteLine("You took " + numberofTries + " tries to roll a ten.");

            Console.ReadKey();
        }
    }
}
