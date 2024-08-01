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
            string newName = Setting.InputString("Ingrese el nombre del nuevo empleado => ");
            string newLastName = Setting.InputString("Ingrese el apellido del nuevo empleado => ");
            string newIdentificateNumber = Setting.InputString("Ingrese el numero de identificacion del nuevo empleado => ");
            int newAge = Setting.InputInt("Ingrese la edad del nuevo empleado => ");
            string newPosition = Setting.InputString("Ingrese la posicion del nuevo empleado => ");
            double newSalary = Setting.InputDouble("Ingrese el salario del nuevo empleado => ");

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

        public static Sale CreatePurchaseProduct(List<Product> availableProducts, List<Employee> availableEmployees, List<Client> clients)
        {
            // Mostrar productos disponibles
            Console.WriteLine("Productos disponibles:");
            for (int i = 0; i < availableProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableProducts[i].Name} - {availableProducts[i].Description} - ${availableProducts[i].Price}");
            }

            // Seleccionar productos por índices
            string saleProducts = Setting.InputString("Ingrese los índices de los productos a vender separados por comas ',' => ");
            var saleProductsIndex = saleProducts.Split(',', ' ').Select(int.Parse).ToList();

            // Crear la lista de productos seleccionados
            List<Product> productsToSell = new List<Product>();
            foreach (var productIndex in saleProductsIndex)
            {
                int indexProduct = productIndex - 1;
                var SaleProduct = availableProducts[indexProduct];
                productsToSell.Add(SaleProduct);
                Console.WriteLine($"{SaleProduct.Name,-32} | {SaleProduct.Description,-13} | {SaleProduct.Price,-14}");
            }

            // Mostrar empleados disponibles
            Console.WriteLine("Empleados disponibles:");
            for (int i = 0; i < availableEmployees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableEmployees[i].GetName()} - {availableEmployees[i].GetLastName()} - {availableEmployees[i].GetAge()}");
            }

            // Seleccionar empleado por índice
            string newEmployee = Setting.InputString("Ingrese el índice del empleado que lo atendió => ");
            int employeeIndex = int.Parse(newEmployee) - 1;
            var selectedEmployee = availableEmployees[employeeIndex];

            // Crear cliente
            var newClient = CreateClient();
            clients.Add(newClient);

            // Crear nueva venta
            var newSale = new Sale(selectedEmployee, newClient, productsToSell);
            return newSale;
        }

    }
}