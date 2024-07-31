using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public class Company(string name, string address)
    {
        public string Name { get; set; } = name;
        public string Address { get; set; } = address;
        public List<Employee> Employees { get; set; } = [];
        public List<Client> Clients { get; set; } = [];

        public void AddEmployee()
        {
            string newName = Setting.InputString("Ingrese el nombre del nuevo empleado: ");
            string newLastName = Setting.InputString("Ingrese el apellido del nuevo empleado: ");
            string newIdentificateNumber = Setting.InputString("Ingrese el numero de identificacion del nuevo empleado: ");
            int newAge = Setting.InputInt("Ingrese la edad del nuevo empleado: ");
            string newPosition = Setting.InputString("Ingrese la posicion del nuevo empleado: ");
            double newSalary = Setting.InputDouble("Ingrese el salario del nuevo empleado: ");

            Employee newEmployee = new(newName, newLastName,  newAge, newIdentificateNumber, newPosition, newSalary);
            Employees.Add(newEmployee);

            Console.WriteLine("");
            Console.WriteLine("Empleado agregado con éxito!");
            Console.WriteLine("");
        }

        public void RemoveEmployee(string name, string lastname)
        {
            Employee? employee = Employees.Find(e => e.Name == name && e.LastName == lastname);
            if (employee != null)
            {
                Employees.Remove(employee);
            }

            Console.WriteLine("");
            Console.WriteLine("Empleado eliminado con éxito!");
            Console.WriteLine("");
        }

        public void ShowEmployees()
        {
            string ShowLineSeparator = new('-', Console.WindowWidth);
            Console.WriteLine($"Nro | {"Nombre",-14} | {"Apellido",-14} | {"Numero Identificador",-14} | {"Edad",-4} | {"Posicion",-14} | {"Salario",-10} | {"Bonificacion",-10}");
            Console.WriteLine(ShowLineSeparator);
            foreach (var employee in Employees)
            {
                employee.ShowInfo();
            }
        }

        public void UpdateEmployee(string IdentificateNumber)
        {
            Employee? employee = Employees.Find(e => e.IdentificateNumber == IdentificateNumber);
            if (employee != null)
            {
                string name = Setting.InputString("Ingrese el nombre del empleado => ");
                string lastName = Setting.InputString("Ingrese el apellido del empleado => ");
                byte age = Setting.InputByte("Ingrese la edad del empleado => ");
                string position = Setting.InputString("Ingrese la posicion del empleado => ");
                double salary = Setting.InputDouble("Ingrese el salario del empleado => ");

                employee.Name = string.IsNullOrEmpty(name) ? employee.Name : name;
                employee.LastName = string.IsNullOrEmpty(lastName) ? employee.LastName : lastName;
                employee.Age = age == 0 ? employee.Age : age;
                employee.Position = string.IsNullOrEmpty(position) ? employee.Position : position;
                employee.Salary = salary == 0 ? employee.Salary : salary;

                Console.WriteLine("");
                Console.WriteLine("Datos actualizados con éxito!");
                Console.WriteLine("");
            }
        }

        public void SearchEmployee(string IdentificateNumber)
        {
            Employee? employee = Employees.Find(e => e.IdentificateNumber == IdentificateNumber);
            if (employee != null)
            {
                employee.ShowInfo();
            }
            else
            {
                Console.WriteLine("No se encontro el empleado con ese numero de identificacion!");
            }
        }

        public void SarchForPosition(string position)
        {
            Employee? employee = Employees.Find(e => e.Position == position);
            if (employee != null)
            {
                employee.ShowInfo();
            }
            else
            {
                Console.WriteLine("No se encontro el empleado con esa posicion!");
            }
        }

        public void AddClient()
        {
            string newName = Setting.InputString("Ingrese el nombre del nuevo cliente => ");
            string newLastName = Setting.InputString("Ingrese el apellido del nuevo cliente => ");
            int newAge = Setting.InputInt("Ingrese la edad del nuevo cliente => ");
            string newEmail = Setting.InputString("Ingrese el email del nuevo cliente => ");
            string newTelephoneNumber = Setting.InputString("Ingrese el numero de telefono del nuevo cliente => ");

            Client newClient = new(newName, newLastName, newAge, newEmail, newTelephoneNumber);
            Clients.Add(newClient);

            Console.WriteLine("");
            Console.WriteLine("Cliente agregado con éxito!");
            Console.WriteLine("");
        }

        public void RemoveClient(string name, string lastname)
        {
            Client? client = Clients.Find(c => c.Name == name && c.LastName == lastname);
            if (client != null)
            {
                Clients.Remove(client);
            }

            Console.WriteLine("");
            Console.WriteLine("Cliente eliminado con éxito!");
            Console.WriteLine("");
        }

        public void ShowClients()
        {
            string ShowLineSeparator = new('-', Console.WindowWidth);
            Console.WriteLine($"Nro | {"Nombre",-14} | {"Apellido",-14} | {"Edad",-4} | {"Email",-14} | {"Numero de Telefono",-14}");
            Console.WriteLine(ShowLineSeparator);
            foreach (var client in Clients)
            {
                client.ShowInfo();
            }
        }
    }
}