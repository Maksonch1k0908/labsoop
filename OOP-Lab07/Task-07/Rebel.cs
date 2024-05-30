public class Rebel : Person, IBuyer
{
    public int Food { get; private set; }
    public string Group { get; private set; }
    public Rebel(string name, int age, string group)
            : base(name, age)
    {
        Group = group;
        Food = 0;
    }
    public void BuyFood()
    {
        Food += 5;
    }
}