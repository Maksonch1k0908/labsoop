public class Program 
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string inputString = Console.ReadLine();
            int inputInt;
            if (int.TryParse(inputString, out inputInt))
            {
                Box<int> intBox = new Box<int>(inputInt);
                Console.WriteLine(intBox.ToString());
            }
            else
            {
                Box<string> stringBox = new Box<string>(inputString);
                Console.WriteLine(stringBox.ToString());
            }
        }
    }
}