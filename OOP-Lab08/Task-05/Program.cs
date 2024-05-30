public class Program
{
    public static void Main()
    {
        string[] nameAndAddress = Console.ReadLine().Split(' ');
        Tuple<string, string> personTuple = new Tuple<string, string>(nameAndAddress[0], nameAndAddress[1]);
        Console.WriteLine($"{personTuple.Item1} -> {personTuple.Item2}");
        string[] nameAndBeer = Console.ReadLine().Split(' ');
        Tuple<string, int> beerTuple = new Tuple<string, int>(nameAndBeer[0], int.Parse(nameAndBeer[1]));
        Console.WriteLine($"{beerTuple.Item1} -> {beerTuple.Item2}");
        string[] integerAndDouble = Console.ReadLine().Split(' ');
        Tuple<int, double> numberTuple = new Tuple<int, double>(int.Parse(integerAndDouble[0]), double.Parse(integerAndDouble[1]));
        Console.WriteLine($"{numberTuple.Item1} -> {numberTuple.Item2}");
    }
}