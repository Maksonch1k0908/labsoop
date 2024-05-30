public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public override bool Equals(object obj)
    {
        if (obj is Person person)
        {
            return Name == person.Name && Age == person.Age;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Age.GetHashCode(); 
    }

    public int CompareTo(Person? other)
    {
        int nameComparison = string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        if (nameComparison != 0)
        {
            return nameComparison;
        }

        return Age.CompareTo(other.Age);
    }
}