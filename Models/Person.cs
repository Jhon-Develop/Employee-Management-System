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

        public string GetName() => Name;
        public string GetLastName() => LastName;
        public int GetAge() => Age;
        public string SetName(string name) => Name = name;
        public string SetLastName(string lastName) => LastName = lastName;
        public int SetAge(int age) => Age = age;

        public abstract void ShowInfo();
    }
}