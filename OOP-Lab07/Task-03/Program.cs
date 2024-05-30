public class Program
{
    public static void Main()
    {
        string driverName = Console.ReadLine();
        Ferrari ferrari = new Ferrari(driverName);
        Console.WriteLine($"{ferrari.Model}" +
            $"{ferrari.PushBrakes()}" +
            $"{ferrari.PushGasPedal()}" +
            $"{ferrari.DriverName}");
    }
}
