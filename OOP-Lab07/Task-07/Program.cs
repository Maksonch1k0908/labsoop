public class FoodShortage
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            if (input.Length == 4)
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string id = input[2];
                string birthdate = input[3];

                Citizen citizen = new Citizen(name, age, id, birthdate);
                people.Add(citizen);
            }
            else if (input.Length == 3)
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string group = input[2];

                Rebel rebel = new Rebel(name, age, group);
                people.Add(rebel);
            }
        }

        string buyerName;
        while ((buyerName = Console.ReadLine()) != "End")
        {
            Person buyer = null;

            foreach (Person person in people)
            {
                if (person.Name == buyerName)
                {
                    buyer = person;
                    break;
                }
            }

            if (buyer is IBuyer)
            {
                IBuyer buyerInterface = (IBuyer)buyer;
                buyerInterface.BuyFood();
            }
        }

        int totalFood = 0;
        foreach (Person person in people)
        {
            if (person is IBuyer)
            {
                IBuyer buyerInterface = (IBuyer)person;
                totalFood += buyerInterface.Food;
            }
        }
        Console.WriteLine(totalFood);
    }
}