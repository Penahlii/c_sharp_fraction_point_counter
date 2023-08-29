namespace Class__Library;

public class Point
{
    // Constructors

    public Point() { }
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    // Properties

    private int x;
    public int X
    {
        set
        {
            if (value >= 0 && value <= 100)
                this.x = value;
        }
        get => this.x;
    }

    private int y = 0;
    public int Y { set; get; }

    // ToString

    public override string ToString()
    {
        string text = $"X: {this.x}, Y: {this.y}";
        return text;
    }

    // Show Data

    public void show_data() => Console.WriteLine($"X: {this.x}, Y: {this.y}");
}
