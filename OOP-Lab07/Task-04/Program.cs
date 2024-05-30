public class Program
{
    public static void Main()
    {
        string[] phoneNumbers = Console.ReadLine().Split(' ');
        string[] websites = Console.ReadLine().Split(' ');
        Smartphone smartphone = new Smartphone();
        
        foreach (string number in phoneNumbers)
        {
            smartphone.Call(number);
        }

        foreach (string website in websites)
        {
            smartphone.Browse(website);
        }
    }
}