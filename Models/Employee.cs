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

        public void ShowInfo(List<Employee> Employees)
        {
            string LineEmployeeSeparator = new('-', Console.WindowWidth);
            Console.WriteLine($"Nro | {"Nombre", -14} | {"Apellido", -14} | {"Numero Identificador", -14} | {"Edad", -4} | {"Posicion", -14} | {"Salario", -10} | {"Bonificacion", -10}");
            Console.WriteLine(LineEmployeeSeparator);
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine($"{i + 1} | {Employees[i].Name, -14} | {Employees[i].LastName, -14} | {Employees[i].IdentificateNumber, -14} | {Employees[i].Age, -4} | {Employees[i].Position, -14} | {Employees[i].BonificationCalculate()}");
                Console.WriteLine(LineEmployeeSeparator);
            }
        }
    }
}