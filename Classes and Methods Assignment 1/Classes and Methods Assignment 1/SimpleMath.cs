using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    class SimpleMath
    {
        public int plusMethod(int x, int y)
        {

            return x + y;
        }

        public decimal minusMethod(decimal a, decimal b)
        {
            return a - b;
        }

        public int multiplyMethod(string s, string w)
        {

            int x = Convert.ToInt32(s);
            int y = Convert.ToInt32(w);

            return x * y;

        }
    }
}
