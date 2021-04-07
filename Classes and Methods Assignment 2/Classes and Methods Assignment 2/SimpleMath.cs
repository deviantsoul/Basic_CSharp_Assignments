using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Classes_and_Methods_Assignment_2
{
    class SimpleMath
    {
        public int plusMethod(int firstNumber, params int[] numbers)
        {
            int temp = 0;
            foreach (int tempNum in numbers)
            {
                temp += tempNum;
            }
            return temp + firstNumber;
        }
    }
}
