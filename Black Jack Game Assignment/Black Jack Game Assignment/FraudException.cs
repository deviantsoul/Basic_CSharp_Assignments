using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_Game_Assignment
{
    class FraudException : Exception
    {
        //inheriting the base exception which is from Exception 
        public FraudException()
            :base() { }
        //overloading instructor
        public FraudException(string message)
            :base(message) { }
    }
}
