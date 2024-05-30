public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<Person> nameSortedSet = new SortedSet<Person>(new NameComparator());
        SortedSet<Person> ageSortedSet = new SortedSet<Person>(new AgeComparator());

        for (int i = 0; i < n; i++)
        {
            string[] personInfo = Console.ReadLine().Split();
            string name = personInfo[0];
            int age = int.Parse(personInfo[1]);

            Person person = new Person(name, age);
            nameSortedSet.Add(person);
            ageSortedSet.Add(person);
        }

        Print(nameSortedSet);
        Print(ageSortedSet);
    }

    static void Print(IEnumerable<Person> people)
    {
        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }
    }
}
