using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath num1 = new SimpleMath();
            Console.WriteLine("The answer is : {0}", num1.plusMethod(5, 2));
            Console.ReadLine();

            SimpleMath num2 = new SimpleMath();
            Console.WriteLine("The answer is : {0}", num2.minusMethod(6.67m, 3.5m));
            Console.ReadLine();

            SimpleMath num3 = new SimpleMath();
            Console.WriteLine("The answer is : {0}", num3.multiplyMethod("20", "2"));
            Console.ReadLine();
        }
    }
}
