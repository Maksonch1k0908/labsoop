using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Person> people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] personInfo = input.Split();
            string name = personInfo[0];
            int age = int.Parse(personInfo[1]);
            string town = personInfo[2];

            Person person = new Person(name, age, town);
            people.Add(person);
        }

        int n = int.Parse(Console.ReadLine());

        Person targetPerson = people[n - 1];

        int equalCount = 0;
        int notEqualCount = 0;

        foreach (Person person in people)
        {
            if (targetPerson != person)
            {
                int comparisonResult = targetPerson.CompareTo(person);
                if (comparisonResult == 0)
                {
                    equalCount++;
                }
                else
                {
                    notEqualCount++;
                }
            }
        }

        if (equalCount > 1)
        {
            Console.WriteLine($"{equalCount} {notEqualCount} {people.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}