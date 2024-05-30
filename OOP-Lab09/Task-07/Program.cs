public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<Person> treeSet = new SortedSet<Person>();
        HashSet<Person> hashSet = new HashSet<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string name = input[0];
            int age = int.Parse(input[1]);
            Person person = new Person(name, age);
            treeSet.Add(person);
            hashSet.Add(person);
        }
        Console.WriteLine(treeSet.Count());
        Console.WriteLine(hashSet.Count());
    }
}