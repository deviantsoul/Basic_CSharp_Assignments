using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    public class Employee : Person
    {
        public int EmployeeID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            bool isTrue = employee.EmployeeID == employee2.EmployeeID;
                return isTrue;
        }
            public static bool operator !=(Employee employee, Employee employee2)
        {
            bool isTrue = employee.EmployeeID != employee2.EmployeeID;
                return isTrue;
        }
    }
}