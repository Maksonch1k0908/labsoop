public class Program
{
    public static void Main()
    {
        List<IIdentifiable> entries = new List<IIdentifiable>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
                break;

            string[] tokens = input.Split(' ');
            if (tokens.Length == 2)
            {
                string model = tokens[0];
                string id = tokens[1];
                entries.Add(new Robot(model, id));
            }
            else if (tokens.Length == 3)
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string id = tokens[2];
                entries.Add(new Citizen(name, age, id));
            }
        }

        string lastDigitsToCheck = Console.ReadLine();

        foreach (IIdentifiable entry in entries)
        {
            if (entry.Id.Contains(lastDigitsToCheck))
            {
                Console.WriteLine(entry.Id);
            }
        }
    }
}
