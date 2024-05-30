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

            if (tokens.Length == 5 && tokens[0] == "Citizen")
            {
                string name = tokens[1];
                int age = int.Parse(tokens[2]);
                string id = tokens[3];
                DateTime birthdate = DateTime.Parse(tokens[4]);
                entries.Add(new Citizen(name, age, id, birthdate));
            }
            else if (tokens.Length == 3 && tokens[0] == "Robot")
            {
                string model = tokens[1];
                string id = tokens[2];
                entries.Add(new Robot(model, id));
            }
            else if (tokens.Length == 3 && tokens[0] == "Pet")
            {
                string name = tokens[1];
                DateTime birthdate = DateTime.Parse(tokens[2]);
                string id = "N/A"; 
                entries.Add(new Pet(name, birthdate, id));
            }
        }

        string yearToCheck = Console.ReadLine();

        foreach (IIdentifiable entry in entries)
        {
            if (entry is IBirthdate birthdateEntry && birthdateEntry.Birthdate.Year == int.Parse(yearToCheck))
            {
                Console.WriteLine($"{birthdateEntry.Birthdate.Day }" +
                    $"{birthdateEntry.Birthdate.Month} " +
                    $"{birthdateEntry.Birthdate.Year} ");
            }
        }
    }
}