public class Chicken
{
    private string name;
    private int age;

    public Chicken(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value < 0 || value > 15)
            {
                throw new ArgumentException("Age should be between 0 and 15.");
            }
            this.age = value;
        }
    }

    private double CalculateProductPerDay()
    {
        if (this.Age <= 3)
        {
            return 1.5;
        }
        else if (this.Age <= 7)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }

    public double ProductPerDay
    {
        get { return this.CalculateProductPerDay(); }
    }

    public override string ToString()
    {
        return $"Chicken {Name} (age {Age}) can produce {ProductPerDay} eggs per day!";
    }
}