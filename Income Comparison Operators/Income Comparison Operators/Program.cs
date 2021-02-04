using System;

namespace Income_Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Please enter Person 1 Hourly Rate: ");
            int Person1HR = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Please Person 1 Hours Worked Per Week: ");
            int Person1HW = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Please enter Person 2 Hourly Rate: ");
            int Person2HR = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Please Person 2 Hours Worked Per Week: ");
            int Person2HW = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 1:");
            Console.ReadLine();
            int Person1AnnualSalary = Person1HR * Person1HW * 52;
            Console.WriteLine(Person1AnnualSalary);
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 2:");
            Console.ReadLine();
            int Person2AnnualSalary = Person2HR * Person2HW * 52;
            Console.WriteLine(Person2AnnualSalary);
            Console.ReadLine();
            Console.WriteLine("Person 1 makes more money than Person 2?");
            Console.ReadLine();
            bool higherSalary = Person1AnnualSalary > Person2AnnualSalary;
            Console.WriteLine(higherSalary);
            Console.ReadLine();
        }
    }
}
