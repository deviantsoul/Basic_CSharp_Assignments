using System;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter value:");
            int number1 = 0;
            number1 = Convert.ToInt32(Console.ReadLine());
            int yourResult = number1 * 50;
            Console.WriteLine("Your number multiply by 50 is: " + yourResult);
            Console.ReadLine();
            Console.WriteLine("Please enter another value:");
            int number2 = 0;
            number2 = Convert.ToInt32(Console.ReadLine());
            int yourResult2 = number2 + 25;
            Console.WriteLine("This time we add 25: " + yourResult2);
            Console.ReadLine();
            Console.WriteLine("Please enter another value:");
            int number3 = 0;
            number3 = Convert.ToInt32(Console.ReadLine());
            double yourResult3 = number3 / 12.5;
            Console.WriteLine("Your number divide it by 12.5: " + yourResult3);
            Console.ReadLine();
            Console.WriteLine("Please enter value:");
            int number4 = 0;
            number4 = Convert.ToInt32(Console.ReadLine());
            bool yourResult4 = number4 > 50;
            Console.WriteLine("Your " + number4 + " is greater than 50? " + yourResult4);
            Console.ReadLine();
            Console.WriteLine("Please enter your last value:");
            int number5 = 0;
            number5 = Convert.ToInt32(Console.ReadLine());
            int yourResult5 = number5 % 7;
            Console.WriteLine("The remainder is: " + yourResult5);
            Console.ReadLine();
        }
    }
}
