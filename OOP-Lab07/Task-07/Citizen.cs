public class Citizen : Person, IBuyer
{
    public int Food { get; private set; }
    public string ID { get; private set; }
    public string Birthdate { get; private set; }
    public Citizen(string name, int age, string id, string birthdate)
           : base(name, age)
    {
        ID = id;
        Birthdate = birthdate;
        Food = 0;
    }

    public void BuyFood()
    {
        Food += 10;
    }
}