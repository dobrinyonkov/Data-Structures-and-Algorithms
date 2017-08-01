using System;
using System.Collections.Generic;

namespace Company
{
    class Employee
    {
        public List<Employee> Subordings { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
            this.Salary = 1;
            this.Subordings = new List<Employee>();
        }
    }
}
