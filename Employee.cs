﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_委托
{
    class Employee
    {
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public static bool Compare(Employee e1, Employee e2)
        {
            if (e1.Salary>e2.Salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
