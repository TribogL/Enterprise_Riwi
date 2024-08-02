using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Riwi.Models;

public class Client : Person
{
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Client(string name, string lastName, int age, string email, string phoneNumber) : base(name, lastName, age)
    {
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public override void ShowInformation()
    {
        Console.WriteLine(@$"////////
Nombre: {Name}
Apellido: {LastName}
Edad: {Age}
Correo: {Email}
Telefóno: {PhoneNumber}
\\\\\\\\\\\\\\\");
    }
    public string GetNameClient()
    {
        return Name;
    }
    public string GetLastNameClient()
    {
        return LastName;
    }
}
