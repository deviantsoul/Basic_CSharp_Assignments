using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Loop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                Console.WriteLine("Count = {0}.", count);
                count++; //stops the infinite loop

                if (count > 50)
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
