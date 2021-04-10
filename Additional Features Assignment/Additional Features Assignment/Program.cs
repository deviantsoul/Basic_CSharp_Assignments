using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myGame = "Guessing Game";
            Console.WriteLine("This is the {0}", myGame);
            Console.ReadLine();

            Console.WriteLine("Please enter your name to be guessed on this {0}: ", myGame);
            var playerName = Console.ReadLine();            
            
            Console.ReadLine();

        }

    }
    
}
