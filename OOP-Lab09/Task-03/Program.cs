public class Program
{
    public static void Main()
    {
        CustomStack<int> customStack = new CustomStack<int>();
        String command;

        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandArgs = command.Split(' ');

            if (commandArgs[0] == "Push")
            {
                for (int i = 1; i < commandArgs.Length; i++)
                {
                    int element = int.Parse(commandArgs[i].TrimEnd(','));
                    customStack.Push(element);
                }
            }
            else if (commandArgs[0] == "Pop")
            {
                 customStack.Pop();
            }
        }

        foreach (int element in customStack)
        {
            Console.WriteLine(element);
        }

        foreach (int element in customStack)
        {
            Console.WriteLine(element);
        }
    }
}