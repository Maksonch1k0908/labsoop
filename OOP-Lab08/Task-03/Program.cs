public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> listString = new List<Box<string>>();
        List<Box<double>> listDouble = new List<Box<double>>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out double boxDouble))
            {
                listDouble.Add(new Box<double>(boxDouble));
            }
            else
            {
                listString.Add(new Box<string>(input));
            }
        }

        string inputText = Console.ReadLine();
        int sumElement = 0;

        if (double.TryParse(inputText, out double inputValue))
        {
            sumElement = Box<double>.ComparingElements(listDouble, inputValue);
        }
        else
        {
            sumElement = Box<string>.ComparingElements(listString, inputText);
        }

        Console.WriteLine(sumElement);
    }
}