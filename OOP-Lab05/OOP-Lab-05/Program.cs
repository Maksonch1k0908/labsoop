public class Program
{
    public static void Main(string[] args)
    {
        double length = Double.Parse(Console.ReadLine());
        double height = Double.Parse(Console.ReadLine());
        double width = Double.Parse(Console.ReadLine());
        Box box = new(length, width, height);

        Console.WriteLine($"Surface area = {box.SurfaceArea()}\n" +
                      $"Lateral surface area = {box.LateralSurfaceArea()}\n" +
                      $"Volume = {box.Volume()}");
    }
}