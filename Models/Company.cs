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
        public List<Employee> Employees { get; set; } =
        [
            new Employee("Alice", "Johnson", 29, "E12345", "Manager", 50000),
            new Employee("Bob", "Smith", 34, "E23456", "Developer", 60000),
            new Employee("Charlie", "Brown", 28, "E34567", "Designer", 55000),
            new Employee("Diana", "Evans", 41, "E45678", "Tester", 45000),
            new Employee("Edward", "Wilson", 37, "E56789", "Support", 40000)
        ];
        public List<Client> Clients { get; set; } = [];
        public List<Product> Products { get; set; } =
        [
            new Product("Laptop", "High-end gaming laptop", 1499.99),
            new Product("Smartphone", "Latest model with 5G", 999.99),
            new Product("Headphones", "Noise-cancelling headphones", 199.99),
            new Product("Smartwatch", "Waterproof smartwatch", 299.99),
            new Product("Tablet", "10-inch screen tablet", 499.99),
            new Product("Monitor", "4K resolution monitor", 399.99),
            new Product("Keyboard", "Mechanical keyboard", 89.99),
            new Product("Mouse", "Wireless mouse", 49.99),
            new Product("Printer", "All-in-one printer", 149.99),
            new Product("Camera", "Digital SLR camera", 899.99),
            new Product("Speaker", "Bluetooth speaker", 79.99),
            new Product("Router", "High-speed wireless router", 129.99),
            new Product("External HDD", "1TB external hard drive", 59.99),
            new Product("SSD", "512GB solid state drive", 119.99),
            new Product("Webcam", "1080p HD webcam", 59.99)
        ];
        public List<Sale> Sales { get; set; } = [];

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
                int age = Setting.InputInt("Ingrese la edad del empleado => ");
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

        public void AddSale(List<Product> products, List<Client> clients, List<Employee> employees)
        {
            ShowProducts();  // Mostrar lista de productos disponibles
            ShowClients();    // Mostrar lista de clientes (si es necesario)
            ShowEmployees(); // Mostrar lista de empleados disponibles

            var newSales = Administration.CreatePurchaseProduct(products, employees, clients);
            Sales.Add(newSales);

            Console.WriteLine("");
            Console.WriteLine("Gracias por su compra!");
            Console.WriteLine("");
        }
        public void RemoveProduct(string name)
        {
            Product? product = Products.Find(p => p.Name == name);
            if (product != null)
            {
                Products.Remove(product);
            }
            else
            {
                Console.WriteLine("No se encontro el producto con ese nombre!");
            }

            Console.WriteLine("");
            Console.WriteLine("Producto eliminado con éxito!");
            Console.WriteLine("");
        }

        public void ShowProducts()
        {
            Setting.LineSeparator('-');
            Console.WriteLine($"Nro | {"Nombre",-14} | {"Descripcion",-14} | {"Precio",-10}");
            Setting.LineSeparator('-');
            foreach (var product in Products)
            {
                product.ShowInfo();
            }
        }

        public void ShowSales()
        {
            Setting.LineSeparator('-');
            Console.WriteLine($"{Setting.Header("Ventas realizadas")}");
            Setting.LineSeparator('-');
            foreach (var sale in Sales)
            {
                Setting.LineSeparator('-');
                sale.ShowInfo();
            }
        }


    }
}