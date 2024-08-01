using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Riwi.Models;

public class Enterprise
{
    public string EnterpriseName { get; set; }
    public string Address { get; set; }
    public static List<Employee> EmployeeList { get; set; } = new List<Employee> { };

    public Enterprise(string enterpriseName, string address, List<Employee> employeeList)
    {
        EnterpriseName = enterpriseName;
        Address = address;
        EmployeeList = employeeList;
    }

    public static void CreateEmployee()
    {
        Console.Write("Ingrese el nombre del Empleado: ");
        string? Name2 = Console.ReadLine();

        Console.Write("Ingrese el apellido del Empleado: ");
        string? LastName2 = Console.ReadLine();

        Console.Write("Ingrese número de documento del Empleado: ");
        string? IdentificationNumber2 = Console.ReadLine();

        Console.Write("Ingrese la edad Empleado: ");
        byte Age2 = byte.Parse(Console.ReadLine());

        Console.Write("Ingrese el cargo del Empleado: ");
        string? Position2 = Console.ReadLine();

        Console.Write("Ingrese el salario del Empleado: ");
        double Salary2 = double.Parse(Console.ReadLine());

        var NewEMployee = new Employee(Name2, LastName2, IdentificationNumber2, Age2, Position2, Salary2);

        EmployeeList.Add(NewEMployee);

    }
    public static void ReadEmployees()
    {
        foreach (var Employee in EmployeeList)
        {
            Employee.ShowInformation();
        }
    }
    public static void UpdateEmployee()
    {
        Console.Write("Ingrese el Nombre del empleado que desea actualizar: ");
        string? employeeForSearch = Console.ReadLine();
        var employeeForFind = EmployeeList.Where(e => e.Name.Equals(employeeForSearch, StringComparison.OrdinalIgnoreCase)).ToList();

        if (employeeForFind.Any())
        {
            var employeeToUpdate = employeeForFind.First();

            bool update = true;
            while (update)
            {
                Console.Write("Ingrese el nombre del Empleado: ");
                string? newName = Console.ReadLine();

                Console.Write("Ingrese el apellido del Empleado: ");
                string? newLastName = Console.ReadLine();

                Console.Write("Ingrese el tipo de documento del Empleado: ");
                string? newIdentificationNumber = Console.ReadLine();

                Console.Write("Ingrese la edad del Empleado: ");
                byte newAge = byte.Parse(Console.ReadLine());

                Console.Write("Ingrese el cargo del Empleado: ");
                string? newPosition = Console.ReadLine();

                Console.Write("Ingrese el salario del Empleado: ");
                double newSalary = double.Parse(Console.ReadLine());

                Console.WriteLine(@"¿Está seguro de los datos ingresados?
1) Sí
2) No");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    employeeToUpdate.Name = newName;
                    employeeToUpdate.LastName = newLastName;
                    employeeToUpdate.IdentificationNumber = newIdentificationNumber;
                    employeeToUpdate.Age = newAge;
                    employeeToUpdate.Position = newPosition;
                    employeeToUpdate.Salary = newSalary;

                    update = false;
                    Console.WriteLine("Empleado actualizado con éxito.");
                }
                else if (selection == 2)
                {
                    Console.WriteLine("Intentelo nuevamente.");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public static void DeleteEmployee()
    {
        Console.Write("Ingrese el Nombre del emplado que desea eliminar del sistema: ");
        string? EmployeeForShearch3 = Console.ReadLine();
        var EmployeeforFind3 = EmployeeList.Where(Name => Name.Name.Equals(EmployeeForShearch3, StringComparison.OrdinalIgnoreCase)).ToList();

        if (EmployeeforFind3.Any())
        {
            bool Delete = true;
            while (Delete)
            {
                foreach (var Employee in EmployeeforFind3)
                {
                    Employee.ShowInformation();
                }
                Console.WriteLine(@"¿Está seguro de elimianr este empleado
1) Sí
2) No");
                int selection3 = int.Parse(Console.ReadLine());
                if (selection3 == 1)
                {
                    foreach (var employee1 in EmployeeforFind3)
                    {
                        EmployeeList.Remove(employee1);
                    }
                    Console.WriteLine("Empleado elimando correctamente");
                    Delete = false;
                }
                else if (selection3 == 2)
                {
                    Console.WriteLine("Saliento del menu de eliminado.");
                    Delete = false;
                }
                else
                {
                    Console.WriteLine("Opción no válida intentelo nuevamente.");

                }
            }
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }



    public static void ShowEmployeeByPosition()
    {
        Console.Write("Ingrese el cargo para ver la lista de empleados: ");
        string? EmployeeForShearch3 = Console.ReadLine();
        var EmployeeforFind3 = EmployeeList.Where(Name => Name.Position.Equals(EmployeeForShearch3, StringComparison.OrdinalIgnoreCase)).ToList();

        if (EmployeeforFind3.Any())
        {
            foreach (var Employee in EmployeeList)
            {
                Employee.ShowInformation();
            }
        }
    }
}