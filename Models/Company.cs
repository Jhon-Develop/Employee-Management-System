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
            var AddEmployee = Administration.CreateEmployee();
            Employees.Add(AddEmployee);
            Console.WriteLine("");
            Console.WriteLine("Empleado agregado con éxito!");
            Console.WriteLine("");
        }

        public void RemoveEmployee(string name, string lastname, string IdentificateNumber)
        {
            Employee? employee = Employees.Find(e => e.GetName() == name && e.GetLastName() == lastname);
            if (employee != null)
            {
                Employees.Remove(employee);
            }
            else
            {
                Console.WriteLine("No se encontro el empleado con ese nombre y apellido!");
            }

            Employee? employeeNumber = Employees.Find(e => e.IdentificateNumber == IdentificateNumber);
            if (employeeNumber != null)
            {
                Employees.Remove(employeeNumber);
            }
            else
            {
                Console.WriteLine("No se encontro el empleado con ese numero de identificacion!");
            }

            Console.WriteLine("");
            Console.WriteLine("Empleado eliminado con éxito!");
            Console.WriteLine("");
        }

        public void ShowEmployees()
        {
            Setting.LineSeparator('-');
            Console.WriteLine($"Nro | {"Nombre",-14} | {"Apellido",-14} | {"Numero Identificador",-14} | {"Edad",-4} | {"Posicion",-14} | {"Salario",-10} | {"Bonificacion",-10}");
            Setting.LineSeparator('-');
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

                employee.SetName(string.IsNullOrEmpty(name) ? employee.GetName() : name);
                employee.SetLastName(string.IsNullOrEmpty(lastName) ? employee.GetLastName() : lastName);
                employee.SetAge(age == 0 ? employee.GetAge() : age);
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
            var AddClient = Administration.CreateClient();
            Clients.Add(AddClient);

            Console.WriteLine("");
            Console.WriteLine("Cliente agregado con éxito!");
            Console.WriteLine("");
        }

        public void RemoveClient(string name, string lastname)
        {
            Client? client = Clients.Find(c => c.GetName() == name && c.GetLastName() == lastname);
            if (client != null)
            {
                Clients.Remove(client);
            }
            else
            {
                Console.WriteLine("No se encontro el cliente con ese nombre y apellido!");
            }

            Console.WriteLine("");
            Console.WriteLine("Cliente eliminado con éxito!");
            Console.WriteLine("");
        }

        public void ShowClients()
        {
            Setting.LineSeparator('-');
            Console.WriteLine($"Nro | {"Nombre",-14} | {"Apellido",-14} | {"Edad",-4} | {"Email",-14} | {"Numero de Telefono",-14}");
            Setting.LineSeparator('-');
            foreach (var client in Clients)
            {
                client.ShowInfo();
            }
        }
    }
}