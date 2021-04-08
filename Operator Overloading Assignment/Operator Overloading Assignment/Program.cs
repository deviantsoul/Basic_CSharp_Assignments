using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Amen";
            employee.LastName = "Tothat";
            employee.EmployeeID = 123456;

            Employee employee2 = new Employee();
            employee.FirstName = "Amen2";
            employee.LastName = "Tothat2";
            employee.EmployeeID = 789012;

            Console.WriteLine(employee != employee2);

            Console.ReadLine();
        }
    }
}
