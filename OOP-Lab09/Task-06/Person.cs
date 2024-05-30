using System;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(Person other)
    {
        return StringComparer.OrdinalIgnoreCase.Compare(this.Name, other.Name);
    }

    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}