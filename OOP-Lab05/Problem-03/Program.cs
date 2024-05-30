public class Progream
{
    public static void Main(string[] args) {
        string name = Console.ReadLine();
        int age = Int32.Parse(Console.ReadLine());
        Chicken chicken = new(name, age);
        Console.WriteLine(chicken);
    }
}