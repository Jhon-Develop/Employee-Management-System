using System_Employee.Models;

namespace System_Employee;

class Program
{
    static void Main(string[] args)
    {
        Company company = new("Nuestra Empresa", "Calle 123, Piso 123");
        bool menuOpen = true;
        while(menuOpen)
        {
            Console.WriteLine($"{Setting.Header("Bienvenidos a Nuestra Empresa")}");
            Console.WriteLine(@"
            1. Empleados.
            2. Clientes.
            3. Productos.
            4. Ventas.
            5. Salir.
            ");
            int option = Setting.InputInt("Ingrese la opción deseada => ");

            switch (option)
            {
                case 1:
                    Console.WriteLine($"{Setting.Header("Empleados")}");
                    Console.WriteLine(@"
                    1. Crear un empleado.
                    2. Ver todos los empleados.
                    3. Eliminar un empleado.
                    4. Actualizar un empleado.
                    5. buscar un empleado.
                    6. Salir.
                    ");
                    int optionEmployee = Setting.InputInt("Ingrese la opción deseada => ");
                    switch (optionEmployee)
                    {
                        case 1:
                            company.AddEmployee();
                            Setting.FinishOption();
                            break;
                        case 2:
                            company.ShowEmployees();
                            break;
                        case 3:
                            string name = Setting.InputString("Ingrese el nombre del empleado => ");
                            string lastName = Setting.InputString("Ingrese el apellido del empleado => ");
                            string IdentificateNumber = Setting.InputString("Ingrese el numero de identificacion del empleado => ");
                            company.RemoveEmployee(name, lastName, IdentificateNumber);
                            break;
                        case 4:
                            string identificateNumber = Setting.InputString("Ingrese el numero de identificacion del empleado => ");
                            company.UpdateEmployee(identificateNumber);
                            break;
                        case 5:
                            Console.WriteLine(@"
                            1. Buscar por numero de identificacion.
                            2. Buscar por posicion.
                            3. Salir.
                            ");
                            int optionSearch = Setting.InputInt("Ingrese la opción deseada => ");
                            switch (optionSearch)
                            {
                                case 1:
                                    string IdentificatesNumber = Setting.InputString("Ingrese el numero de identificacion del empleado => ");
                                    company.SearchEmployee(IdentificatesNumber);
                                    break;
                                case 2:
                                    string position = Setting.InputString("Ingrese la posicion del empleado => ");
                                    company.SarchForPosition(position);
                                    break;
                                case 3:
                                    menuOpen = false;
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida!");
                                    break;
                            }
                            break;
                        case 6:
                            menuOpen = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida!");
                            break;
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opción no válida!");
                    break;
            }
        }
    }
}