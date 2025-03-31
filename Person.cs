using System;

namespace Ucu.Poo.Persons;

public class Person
{
    private string name;
    public string Name
    {
        get { return name; } set { name = value; }
    }

    private string id;
    public string Id
    {
        get { return id; } set { id = value; }
    }

    public Person(string name, string id)
    {
        this.Name = name;
        this.Id = id;
    }

    public void IntroduceYourself()
    {
        Console.WriteLine(
            $"Soy {this.Name} y mi cédula es {this.Id}");
    }
    
}