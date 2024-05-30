public class Smartphone : ICall, IBrowse
{
    public void Call(string number)
    {
        Console.WriteLine(IsAllDigits(number) ? $"Calling... {number}" : "Invalid number!");
    }

    public void Browse(string website)
    {
        
        Console.WriteLine(ContainsDigits(website) ? "Invalid URL!" : $"Browsing: {website}!");
    }

    private bool IsAllDigits(string text)
    {
        foreach (char c in text)
        {
            if (!char.IsDigit(c))
            {
                char.IsNumber(c);
                return false;
            }
        }
        return true;
    }

    private bool ContainsDigits(string text)
    {
        foreach (char c in text)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}