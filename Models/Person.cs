using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Riwi.Models;

public abstract class Person
{
    protected Guid Id { get; set; }
    protected static string Name { get; set; }
    protected static string LastName { get; set; }
    protected static int Age { get; set; }
    public Person(string name, string lastName, int age)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        Age = age;
    }

    public abstract void ShowInformation();

    public static void NewNameEmployee(string name)
    {
        Name = name;
    }

    public static void NewLastNameEmployee(string lastName)
    {
        LastName = lastName;
    }

   
}

