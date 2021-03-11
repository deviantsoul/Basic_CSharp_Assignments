using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excemption_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                Console.ReadLine();
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message); //You can replace this with your own message
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't use zero to divide."); //instead of ex.Message
            }
            catch (Exception ex)  //general excemptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
