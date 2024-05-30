public class Box<T>
{
    public T Value { set; get; }
    public Box(T value)
    {
        Value = value;
    }
    
    public override string ToString()
    {
        string name = Value.GetType().FullName; 
        return $"{name}: {Value}";
    }

    public static int ComparingElements(List<Box<T>> list, T value)
    {
        int count = 0;
        foreach (Box<T> item in list)
        {
            if (Comparer<T>.Default.Compare(item.Value, value) > 0)
            {
                count++;
            }
        }

        return count;
    }
}