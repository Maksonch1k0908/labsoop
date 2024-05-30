public class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get { return length; }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Length should be a positive num!");
                length = 0;
            }
            else
            {
            length = value;
            }
        }
    }

    public double Width
    {
        get { return width; }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Width should be a positive num!");
                width = 0;
            }
            else
            {
                width = value;
            }
        }
    }

    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Height should be a positive num!");
                height = 0;
            }
            else 
            { 
                height = value;
            }
        }
    }

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double SurfaceArea()
    {
        return 2 * (length * width + length * height + width * height);
    }

    public double LateralSurfaceArea()
    {
        return 2 * (length * height + width * height);
    }

    public double Volume()
    {
        return length * width * height;
    }
}