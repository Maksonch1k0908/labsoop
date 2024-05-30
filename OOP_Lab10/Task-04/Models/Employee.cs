public abstract class Employee
{
    public int HoursPerWeek { get; private set; }
    public string Name { get; private set; }
    public Employee(string name, int hoursPerWeek)
    {
        Name = name;
        HoursPerWeek = hoursPerWeek;
    }
}