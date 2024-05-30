using System.Collections;

public class CustomList<T> : IEnumerable<T> where T : IComparable<T>
{
    private List<T> elements;

    public CustomList()
    {
        this.elements = new List<T>();
    }

    public void Add(T element)
    {
        this.elements.Add(element);
    }

    public T Remove(int index)
    {
        T removedElement = this.elements[index];
        this.elements.RemoveAt(index);
        return removedElement;
    }

    public bool Contains(T element)
    {
        return this.elements.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        T temp = this.elements[index1];
        this.elements[index1] = this.elements[index2];
        this.elements[index2] = temp;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;
        foreach (T el in this.elements)
        {
            if (el.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }

    public T Max()
    {
        T maxElement = this.elements[0];
        foreach (T element in this.elements)
        {
            if (element.CompareTo(maxElement) > 0)
            {
                maxElement = element;
            }
        }
        return maxElement;
    }

    public T Min()
    {
        T minElement = this.elements[0];
        foreach (T element in this.elements)
        {
            if (element.CompareTo(minElement) < 0)
            {
                minElement = element;
            }
        }
        return minElement;
    }

    public void Sort()
    {
        this.elements.Sort();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}