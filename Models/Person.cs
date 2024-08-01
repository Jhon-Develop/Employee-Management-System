using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public abstract class Person (string name, string lastName, int age)
    {
        protected Guid Id { get; set; } = Guid.NewGuid();
        protected string Name { get; set; } = name;
        protected string LastName { get; set; } = lastName;
        protected int Age { get; set; } = age;

        public abstract void ShowInfo();
    }
}