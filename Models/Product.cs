using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public class Product(string name, string description, double price)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public double Price { get; set; } = price;        

        public void ShowInfo()
        {
            Setting.LineSeparator('-');
            Console.WriteLine($"{Id} | {Name,-14} | {Description,-14} | {Price,-4}");
            Setting.LineSeparator('-');
        }
    }
}