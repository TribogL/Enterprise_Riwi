using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Riwi.Models;

public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    public Person(string name, string lastName, byte age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }

    public void ShowInformation()
    {
        Console.WriteLine(@$"////////
Nombre: {Name}
Apellido: {LastName}
Edad: {Age}
\\\\\\\\\\\\\\\");
    }
}
