using System.Xml.Linq;

class Footman : Soldier
{
    public Footman(string name)
        : base(name)
    {
    }

    public override void RespondToAttack()
    {
        Console.WriteLine($"Footman {Name} is panicking!");
    }
}