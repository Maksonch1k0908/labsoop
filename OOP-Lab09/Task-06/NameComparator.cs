public class NameComparator : IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        int nameLengthComparison = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);
        if (nameLengthComparison != 0)
        {
            return nameLengthComparison;
        }

        return StringComparer.OrdinalIgnoreCase.Compare(firstPerson.Name[0], secondPerson.Name[0]);
    }
}