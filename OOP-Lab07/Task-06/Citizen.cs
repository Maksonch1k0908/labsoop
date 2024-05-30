public class Citizen : IIdentifiable, IBirthdate
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }
    public DateTime Birthdate { get; private set; }

    public Citizen(string name, int age, string id, DateTime birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }
}