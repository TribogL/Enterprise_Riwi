using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Riwi.Models;

public static class Managger
{

    public static Client CreateClient()
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

        return NewClient;

    }
    public static Employee CreateEmployee()
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

        return NewEMployee;

        Console.WriteLine("Desea ver el empleado?");


    }
    public static void ShowTitle()
    {
        Console.WriteLine(@"///////////////Bienvenido a Enterprise Riwi\\\\\\\\\\\\\\\\\\\");
        Console.WriteLine(@"Menu principal
1)Menu de empleados
2)Menu de clientes.
3)salir.");
    }


    public static void ShowFoot()
    {
        Console.WriteLine(@"///////// Saliendo del menu \\\\\\\\\\");
    }


    public static void ShowSpaces()
    {

    }


    
}

