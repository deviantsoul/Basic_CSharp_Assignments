using System;

namespace Price_Quote_Application
{
    class Program
    {
        static void Main()
        {
            int pWeight;
            int pWidth;
            int pHeight;
            int pLength;
            int totalCost;
            decimal priceQuote = 0.00m;
            string input;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight:");
            input = Console.ReadLine();
            pWeight = Convert.ToInt32(input);
            if (pWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            
            Console.WriteLine("Please enter the package width.");
            input = Console.ReadLine();
            pWidth = Convert.ToInt32(input);

            if (pWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package height.");
            input = Console.ReadLine();
            pHeight = Convert.ToInt32(input);

            if ((pWidth + pHeight) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package length.");
            input = Console.ReadLine();
            pLength = Convert.ToInt32(input);
            
            if ((pWidth + pHeight + pLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            totalCost = ((pWidth * pHeight * pLength) * pWeight) / 100;
            priceQuote = Convert.ToDecimal(totalCost);
            
            Console.WriteLine("Your estimated total for shipping this package is: " + priceQuote.ToString("C2") + ".");
            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
}
