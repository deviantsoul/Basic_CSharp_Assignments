using System;

namespace Student_Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you in?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your current course is " + yourCourse + ".");
            Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pNumber = Convert.ToInt32(pageNumber);
            Console.WriteLine("You are currently at page " + pNumber + ".");
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything?");
            Console.WriteLine("Please enter True or False");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("You replied " + answer + ". Thanks for letting us know.");
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourSpecifics = Console.ReadLine();
            Console.WriteLine("You wrote: " + yourSpecifics + ". Thanks for the response.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("You wrote: " + yourFeedback + ". Thanks for your feedback.");
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
