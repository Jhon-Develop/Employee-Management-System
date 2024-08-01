using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public class Administration
    {
        public static Employee CreateEmployee()
        {
            string newName = Setting.InputString("Ingrese el nombre del nuevo empleado: ");
            string newLastName = Setting.InputString("Ingrese el apellido del nuevo empleado: ");
            string newIdentificateNumber = Setting.InputString("Ingrese el numero de identificacion del nuevo empleado: ");
            int newAge = Setting.InputInt("Ingrese la edad del nuevo empleado: ");
            string newPosition = Setting.InputString("Ingrese la posicion del nuevo empleado: ");
            double newSalary = Setting.InputDouble("Ingrese el salario del nuevo empleado: ");

            var newEmployee = new Employee(newName, newLastName, newAge, newIdentificateNumber, newPosition, newSalary);
            return newEmployee;
        }

        public static Client CreateClient()
        {
            string newName = Setting.InputString("Ingrese el nombre del nuevo cliente => ");
            string newLastName = Setting.InputString("Ingrese el apellido del nuevo cliente => ");
            int newAge = Setting.InputInt("Ingrese la edad del nuevo cliente => ");
            string newEmail = Setting.InputString("Ingrese el email del nuevo cliente => ");
            string newTelephoneNumber = Setting.InputString("Ingrese el numero de telefono del nuevo cliente => ");

            var newClient = new Client(newName, newLastName, newAge, newEmail, newTelephoneNumber);
            return newClient;
        }
    }
}