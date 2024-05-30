public class Box<T>
{
    public T value { set; get; }
    public Box(T value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        string name = value.GetType().FullName; 
        return $"{name}: {value}";
    }
}