public class Pet : IIdentifiable, IBirthdate
{
    public string Name { get; }
    public DateTime Birthdate { get; }
    public string Id { get; } 

    public Pet(string name, DateTime birthdate, string id)
    {
        Name = name;
        Birthdate = birthdate;
        Id = id;
    }
}