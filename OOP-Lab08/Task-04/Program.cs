public class Program
{
    public static void Main()
    {
        CustomList<string> customList = new CustomList<string>();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] tokens = command.Split();

            switch (tokens[0])
            {
                case "Add":
                    customList.Add(tokens[1]);
                    break;

                case "Remove":
                    int indexToRemove = int.Parse(tokens[1]);
                    Console.WriteLine(customList.Remove(indexToRemove));
                    break;

                case "Contains":
                    Console.WriteLine(customList.Contains(tokens[1]));
                    break;

                case "Swap":
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    customList.Swap(index1, index2);
                    break;

                case "Greater":
                    Console.WriteLine(customList.CountGreaterThan(tokens[1]));
                    break;

                case "Max":
                    Console.WriteLine(customList.Max());
                    break;

                case "Min":
                    Console.WriteLine(customList.Min());
                    break;

                case "Sort":
                    Sorter.Sort(customList);
                    break;

                case "Print":
                    foreach (string element in customList)
                    {
                        Console.WriteLine(element);
                    }
                    break;
            }
        }
    }
}
