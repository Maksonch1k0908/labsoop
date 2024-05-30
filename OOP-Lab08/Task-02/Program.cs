public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> list = new List<Box<string>>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Box<string> box = new Box<string>(input);
            list.Add(box);
        }

        string[] input_n = Console.ReadLine().Split(' ');
        int n1 = int.Parse(input_n[0]);
        int n2 = int.Parse(input_n[1]);
        Swap(list, n1, n2);

        foreach (Box<string> box in list)
        {
            int boxInt;
            if (int.TryParse(box.value, out boxInt))
            {
                Box<int> intBox = new Box<int>(boxInt);
                Console.WriteLine(intBox.ToString());
            }
            else
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
    public static void Swap<T>(List<T> list, int index1, int index2)
    {
        T element = list[index1];
        list[index1] = list[index2];
        list[index2] = element;
    }
}