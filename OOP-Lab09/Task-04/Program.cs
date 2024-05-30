public class Program
{
    public static void Main()
    {
        int[] stoneNumbers = Array.ConvertAll(Console.ReadLine().Split(", "), int.Parse);

        Lake<int> lake = new Lake<int>(stoneNumbers);

        foreach (int stone in lake)
        {
            Console.Write(stone + ", ");
        }
    }
}
