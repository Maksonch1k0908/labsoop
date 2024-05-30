using System.Collections;

public class CustomStack<T> : IEnumerable<T>
{
    private List<T> elements;

    public CustomStack()
    {
        elements = new List<T>();
    }

    public void Push(T element)
    {
        elements.Add(element);
    }

    public void Pop()
    {
        if (elements.Count > 0)
        {
            elements.RemoveAt(elements.Count - 1);
        }
        else
        {
            Console.WriteLine("No elements");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = elements.Count - 1; i >= 0; i--)
        {
            yield return elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}