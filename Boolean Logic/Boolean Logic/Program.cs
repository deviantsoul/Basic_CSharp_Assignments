using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Qualifier");
            Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please answer Yes or No.");
            Console.ReadLine();
            bool Yes = true;
            bool No = false;
            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            bool Qualified = (age > 15) && Yes && (ticket <= 3);
            Console.WriteLine("Qualified? - " + Qualified);
            Console.ReadLine();
        }
    }
}