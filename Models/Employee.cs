using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public class Employee(string name, string lastName, string identificateNumber, byte age, string position, double salary)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;
        public string IdentificateNumber { get; set; } = identificateNumber;
        public byte Age { get; set; } = age;
        public string Position { get; set; } = position;
        public double Salary { get; set; } = salary;

        private double BonificationCalculate()
        {
            double bond = Salary * 0.1;
            bond += Salary;
            return bond;
        }

        public void ShowInfo()
        {
            string LineEmployeeSeparator = new('-', Console.WindowWidth);
            Console.WriteLine($"{Id} | {Name,-14} | {LastName,-14} | {IdentificateNumber,-14} | {Age,-4} | {Position,-14} | {BonificationCalculate()}");
            Console.WriteLine(LineEmployeeSeparator);

        }
    }
}