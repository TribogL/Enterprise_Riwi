using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Riwi.Models;

public abstract class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Person(string name, string lastName, int age)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        Age = age;
    }

    public abstract void ShowInformation();

}
