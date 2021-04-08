using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class SimpleMath
    {
        public void myDivide(int x)
        {
            Console.WriteLine(x / 2);
        }

        //overloading a method
        public void myDivide(int x, int y)
        {
            Console.WriteLine(x * y / 2);
           
        }

        //output parameters. Just humor me please
        public void myTest(out int x)
        {
            int temp = 785;
            x = temp;
        }        

    }
}
