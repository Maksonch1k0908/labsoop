using System.Collections;

public class ListyIterator<T> : IEnumerable<T> 
{
    private List<T> elements;
    private int currentIndex;

    public ListyIterator(IEnumerable<T> collection)
    {
        this.elements = new List<T>(collection);
        this.currentIndex = 0;
    }

    public bool Move()
    {
        if (this.HasNext())
        {
            this.currentIndex++;
            return true;
        }

        return false;
    }

    public bool HasNext()
    {
        return this.currentIndex < this.elements.Count - 1;
    }

    public void Print()
    {
        if (this.elements.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine(this.elements[this.currentIndex]);
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join(" ", this.elements));
    }


    public IEnumerator<T> GetEnumerator()
    {
        foreach (T elements in elements)
        {
            yield return elements;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
