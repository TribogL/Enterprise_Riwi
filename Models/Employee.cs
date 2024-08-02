using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Riwi.Models;

public class Employee : Person
{

    public string IdentificationNumber { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }


    public Employee(string name, string lastName, string identificationNumber, int age, string position, double salary) : base(name, lastName, age)
    {

        IdentificationNumber = identificationNumber;
        Position = position;
        Salary = salary;
    }
    private double BonificationFounder()
    {
        double Bonification = (Salary * 0.10);
        return Bonification;
    }

    public override void ShowInformation()
    {
        Console.WriteLine(@$"////////
Nombre: {Name}
Apellido: {LastName}
Carné: {IdentificationNumber}
Edad: {Age}
Cargo: {Position}
Salario bruto: {Salary}
bonificación: {BonificationFounder()}
salario total: {Salary + BonificationFounder()}
\\\\\\\\\\\\\\\");
    }

    public string GetNameEmployee()
    {
        return Name;
    }

    public string GetLastNameEmployee()
    {
        return LastName;
    }
    


}