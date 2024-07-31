using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public class Person (string name, string lastName, int age)
    {
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;
        public int Age { get; set; } = age;
    }
}