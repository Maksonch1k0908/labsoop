public class Ferrari : ICar
{
    public string Model { get; private set; }
    public string DriverName { get; private set; }
    public Ferrari(string driverName)
    {
        Model = "488-Spider";
        DriverName = driverName;
    }
    public string PushBrakes()
    {
        return "Brakes!";
    }

    public string PushGasPedal()
    {
        return "Zadu6avam sA!";
    }
}
