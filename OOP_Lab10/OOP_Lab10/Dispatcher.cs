public class Dispatcher
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (name != value)
            {
                name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }
    }

    public event NameChangeEventHandler NameChange;
    public virtual void OnNameChange(NameChangeEventArgs args)
    {
        NameChange.Invoke(this, args);
    }
}
