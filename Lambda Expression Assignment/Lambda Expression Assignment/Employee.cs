﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Employee(string _FirstName, string _LastName, int _Id)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Id = _Id;
        }
    }
}
