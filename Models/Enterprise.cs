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
    public static List<Client> ClientList { get; set; } = new List<Client> { };

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
        int Age2 = int.Parse(Console.ReadLine());

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
                int newAge = int.Parse(Console.ReadLine());

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
        bool delete5 = true;
        while (delete5)
        {


            Console.WriteLine(@"Como desesa buscar al Empleado?
1)Nombre.
2)Apellido.
3)Numero de identificacion");
            int selection4 = int.Parse(Console.ReadLine());
            if (selection4 == 1)
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
            else if (selection4 == 2)
            {
                Console.Write("Ingrese el apellido del empleado que desea eliminar del sistema: ");
                string? EmployeeForShearch3 = Console.ReadLine();
                var EmployeeforFind3 = ClientList.Where(LastName => LastName.LastName.Equals(EmployeeForShearch3, StringComparison.OrdinalIgnoreCase)).ToList();

                if (EmployeeforFind3.Any())
                {
                    bool Delete3 = true;
                    while (Delete3)
                    {
                        foreach (var client in EmployeeforFind3)
                        {
                            client.ShowInformation();
                        }
                        Console.WriteLine(@"¿Está seguro de elimianr este cliente?
1) Sí
2) No");
                        int selection6 = int.Parse(Console.ReadLine());
                        if (selection6 == 1)
                        {
                            foreach (var client in EmployeeforFind3)
                            {
                                ClientList.Remove(client);
                            }
                            Console.WriteLine("Cliente elimando correctamente.");
                            Delete3 = false;
                        }
                        else if (selection6 == 2)
                        {
                            Console.WriteLine("Saliento del menu de eliminado.");
                            Delete3 = false;
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida intentelo nuevamente.");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("cliente no encontrado.");
                }
            }
            else if (selection4 == 3)
            {
                Console.Write("Ingrese el numero de identificacion del empleado que desea eliminar del sistema: ");
                string? EmployeeForShearch3 = Console.ReadLine();
                var EmployeeforFind3 = EmployeeList.Where(Idefication => Idefication.IdentificationNumber.Equals(EmployeeForShearch3, StringComparison.OrdinalIgnoreCase)).ToList();

                if (EmployeeforFind3.Any())
                {
                    bool Delete3 = true;
                    while (Delete3)
                    {
                        foreach (var employee in EmployeeforFind3)
                        {
                            employee.ShowInformation();
                        }
                        Console.WriteLine(@"¿Está seguro de elimianr este cliente?
1) Sí
2) No");
                        int selection6 = int.Parse(Console.ReadLine());
                        if (selection6 == 1)
                        {
                            foreach (var employee in EmployeeforFind3)
                            {
                                EmployeeList.Remove(employee);
                            }
                            Console.WriteLine("Cliente elimando correctamente.");
                            Delete3 = false;
                        }
                        else if (selection6 == 2)
                        {
                            Console.WriteLine("Saliento del menu de eliminado.");
                            Delete3 = false;
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida intentelo nuevamente.");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("cliente no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Opcción no valida intentelo nuevamente.");
            }
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


    public static void CreateClient()
    {
        Console.Write("Ingrese el nombre del client: ");
        string? Name3 = Console.ReadLine();

        Console.Write("Ingrese el apellido del cliente ");
        string? LastName3 = Console.ReadLine();

        Console.Write("Ingrese la edad Empleado: ");
        int Age3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el correo del cliente: ");
        string? Email3 = Console.ReadLine();

        Console.Write("Ingrese el telefóno del cliente: ");
        string? PhoneNumber3 = Console.ReadLine();

        var NewClient = new Client(Name3, LastName3, Age3, Email3, PhoneNumber3);

        ClientList.Add(NewClient);

    }
    public static void ReadClient()
    {
        foreach (var client in ClientList)
        {
            client.ShowInformation();
        }
    }
    public static void UpdateClient()
    {
        Console.Write("Ingrese el Nombre del empleado que desea actualizar: ");
        string? ClientForSearch = Console.ReadLine();
        var ClientForFind = ClientList.Where(e => e.Name.Equals(ClientForSearch, StringComparison.OrdinalIgnoreCase)).ToList();

        if (ClientForFind.Any())
        {
            var ClientToUpdate = ClientForFind.First();

            bool update = true;
            while (update)
            {
                Console.Write("Ingrese el nombre del cliente: ");
                string? newName2 = Console.ReadLine();

                Console.Write("Ingrese el apellido del cliente: ");
                string? newLastName2 = Console.ReadLine();

                Console.Write("Ingrese la edad del cliente: ");
                byte newAge2 = byte.Parse(Console.ReadLine());

                Console.Write("Ingrese el Email del cliente: ");
                string? newEmail = Console.ReadLine();

                Console.Write("Ingrese el Telefóno del cliente: ");
                string? newPhoneNumber = Console.ReadLine();

                Console.WriteLine(@"¿Está seguro de los datos ingresados?
1) Sí
2) No");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    ClientToUpdate.Name = newName2;
                    ClientToUpdate.LastName = newLastName2;
                    ClientToUpdate.Age = newAge2;
                    ClientToUpdate.Email = newEmail;
                    ClientToUpdate.PhoneNumber = newPhoneNumber;

                    update = false;
                    Console.WriteLine("Cliente actualizado con éxito.");
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
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    public static void DeleteClient()
    {
        Console.WriteLine(@"Como desesa buscar al cliente?
1)Nombre.
2)Apellido.");
        int selection4 = int.Parse(Console.ReadLine());
        if (selection4 == 1)
        {
            Console.Write("Ingrese el Nombre del cliente que desea eliminar del sistema: ");
            string? ClientForSearch3 = Console.ReadLine();
            var ClientForFind3 = ClientList.Where(Name => Name.Name.Equals(ClientForSearch3, StringComparison.OrdinalIgnoreCase)).ToList();

            if (ClientForFind3.Any())
            {
                bool Delete2 = true;
                while (Delete2)
                {
                    foreach (var client in ClientForFind3)
                    {
                        client.ShowInformation();
                    }
                    Console.WriteLine(@"¿Está seguro de elimianr este cliente?
1) Sí
2) No");
                    int selection5 = int.Parse(Console.ReadLine());
                    if (selection5 == 1)
                    {
                        foreach (var client in ClientForFind3)
                        {
                            ClientList.Remove(client);
                        }
                        Console.WriteLine("Cliente elimando correctamente.");
                        Delete2 = false;
                    }
                    else if (selection5 == 2)
                    {
                        Console.WriteLine("Saliento del menu de eliminado.");
                        Delete2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida intentelo nuevamente.");

                    }
                }
            }
            else
            {
                Console.WriteLine("cliente no encontrado.");
            }
        }
        else if (selection4 == 2)
        {
            Console.Write("Ingrese el apellido del cliente que desea eliminar del sistema: ");
            string? ClientForSearch4 = Console.ReadLine();
            var ClientForFind4 = ClientList.Where(LastName => LastName.LastName.Equals(ClientForSearch4, StringComparison.OrdinalIgnoreCase)).ToList();

            if (ClientForFind4.Any())
            {
                bool Delete3 = true;
                while (Delete3)
                {
                    foreach (var client in ClientForFind4)
                    {
                        client.ShowInformation();
                    }
                    Console.WriteLine(@"¿Está seguro de elimianr este cliente?
1) Sí
2) No");
                    int selection6 = int.Parse(Console.ReadLine());
                    if (selection6 == 1)
                    {
                        foreach (var client in ClientForFind4)
                        {
                            ClientList.Remove(client);
                        }
                        Console.WriteLine("Cliente elimando correctamente.");
                        Delete3 = false;
                    }
                    else if (selection6 == 2)
                    {
                        Console.WriteLine("Saliento del menu de eliminado.");
                        Delete3 = false;
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida intentelo nuevamente.");

                    }
                }
            }
            else
            {
                Console.WriteLine("cliente no encontrado.");
            }
        }
    }
}