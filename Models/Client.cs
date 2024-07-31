using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public class Client(string name, string lastName, int age, string email, string telephoneNumber) : Person(name, lastName, age)
    {
        public string Email { get; set; } = email;
        public string TelephoneNumber { get; set; } = telephoneNumber;

        public override void ShowInfo()
        {
            string LineClinetSeparator = new('-', Console.WindowWidth);
            Console.WriteLine($"{Name,-14} | {LastName,-14} | {Age,-4} | {Email,-14} | {TelephoneNumber,-14}");
            Console.WriteLine(LineClinetSeparator);
        }
    }
}