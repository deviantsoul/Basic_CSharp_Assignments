using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            List<string> FirstNames = new List<string>()
            {
                "Paisely", "Laura", "Ivy", "Stephanie", "Jean", "Maui", "Crystal", "Joe", "Joe", "Dua"
            };

            List<string> LastNames = new List<string>()
            {
                "Smith", "Goddess", "Sy", "Lee", "Sexy", "Taylor", "Mana", "Amen", "Amazing", "Lipa"
            };

            List<int> IDs = new List<int>()
            {
                1, 6, 2, 3, 7, 9, 8, 4, 5, 12
            };

            int i = 0;
            foreach (string firstName in FirstNames)
            {
                Employees.Add(new Employee(firstName, LastNames[i], IDs[i]));
                i++;
            }                      

            List<Employee> joeList = Employees.Where( x => x.FirstName.Contains("Joe")).ToList();

            foreach (Employee joes in joeList)
            {
                Console.WriteLine(joes.FirstName);
            }
            Console.ReadLine();

            List<Employee> moreThanFive = Employees.Where(y => y.Id > 5).ToList();

            foreach (Employee myFives in moreThanFive)
            {
                Console.WriteLine(myFives.Id);
            }
            Console.ReadLine();


        }
    }
}
