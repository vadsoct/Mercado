using System;
using Mercado.Entities.Enums;
using System.Collections;
using System.Globalization;

namespace Mercado.Entities
{
    public class Client
    {
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }

    public Client()
    {
    }
    public Client(string nome, string email , DateTime birthDate)
    {
        Nome = nome;
        Email = email;
        birthDate = BirthDate;
    }

    }
}