public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        ListyIterator<string> listyIterator = new ListyIterator<string>(input);

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            switch (command)
            {
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;

                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;

                case "Print":
                    listyIterator.Print();
                    break;

                case "PrintAll":
                    listyIterator.PrintAll();
                    break;
                default:
                    Console.WriteLine("Invalid Operation!");
                    break;
            }
        }
    }
}