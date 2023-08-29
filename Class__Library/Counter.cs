namespace Class__Library;

public class Counter
{
    private int current_data;
    private int max;

    // Constructors

    public Counter() { }
    public Counter(int min, int max)
    {
        this.max = max;
        this.Min = min;
        this.current_data = min;
    }

    // Properties

    private int min;
    public int Min
    {
        set
        {
            if (value < this.max)
                this.min = value;
            else
                throw new ArgumentException("Min number can not be greater than max number");
        }
        get => this.min;
    }

    // increment, decriment

    public void incriment()
    {
        this.current_data++;
        if (this.current_data > this.max)
            this.current_data = this.min;
    }
    public void decriment()
    {
        this.current_data--;
        if (this.current_data < this.min)
            this.current_data = this.max;
    }

    // Get Current Data

    public int Current() => this.current_data;

    // ToString

    public override string ToString()
    {
        string text = $"{this.current_data}";
        return text;
    }
}