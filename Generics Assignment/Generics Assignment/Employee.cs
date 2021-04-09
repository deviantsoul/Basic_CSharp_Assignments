using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    public class Employee<T> : Person
    {
        public List<T> Things { get; set; }
        public int EmployeeID { get; set; }
    }
}
