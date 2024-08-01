using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Riwi.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string IdentificationNumber { get; set; }
    public byte Age { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }


    public Employee(string name, string lastName, string identificationNumber, byte age, string position, double salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        IdentificationNumber = identificationNumber;
        Age = age;
        Position = position;
        Salary = salary;
    }
    private double BonificationFounder()
    {
        double Bonification = (Salary * 0.10);
        return Bonification;       
    }
    
    public void ShowInformation()
    {
        Console.WriteLine(@$"////////
Nombre: {Name}
Apellido: {LastName}
Carné: {IdentificationNumber}
Edad: {Age}
Cargo: {Position}
Salario: {Salary}
bonificación: {BonificationFounder()}
\\\\\\\\\\\\\\\");
    }

}