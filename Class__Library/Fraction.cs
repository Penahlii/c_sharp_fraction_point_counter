namespace Class__Library;

public class Fraction
{
    // Constructors

    public Fraction() { }
    public Fraction(int num, int den)
    {
        this.denominator = den;
        this.numerator = num;
    }

    // Properties

    private int numerator;
    public int Numerator { set; get; }

    private int denominator;
    public int Denominator
    {
        set
        {
            if (value > 0)
                this.denominator = value;
            else
                throw new ArgumentException("Denominator can not be zero");
        }
        get => this.denominator;
    }

    // Simplify

    public void Simplify()
    {
        int elave = 1;
        int a = this.numerator;
        int b = this.denominator;
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        elave = a;
        this.numerator /= elave;
        this.denominator /= elave;
    }

    // + Methods

    public Fraction Multiply(ref Fraction other)
    {
        int num = this.numerator * other.numerator;
        int den = this.denominator * other.denominator;
        Fraction result = new Fraction(num, den);
        result.Simplify();
        return result;
    }

    public Fraction Add(ref Fraction other)
    {
        if (this.denominator == other.denominator)
        {
            int num = this.numerator + other.numerator;
            Fraction result = new Fraction(num, this.denominator);
            result.Simplify();
            return result;
        }
        else
        {
            int num = (this.numerator * other.denominator) + (this.denominator * other.numerator);
            int den = this.denominator * other.denominator;
            Fraction result = new Fraction(num, den);
            result.Simplify();
            return result;
        }
    }

    public Fraction Minus(ref Fraction other)
    {
        if (this.denominator == other.denominator)
        {
            int num = this.numerator - other.numerator;
            Fraction result = new Fraction(num, this.denominator);
            result.Simplify();
            return result;
        }
        else
        {
            int num = (this.numerator * other.denominator) - (this.denominator * other.numerator);
            int den = this.denominator * other.denominator;
            Fraction result = new Fraction(num, den);
            result.Simplify();
            return result;
        }
    }

    public Fraction Divide(ref Fraction other)
    {
        int num = this.numerator * other.denominator;
        int den = this.denominator * other.numerator;
        Fraction result = new Fraction(num, den);
        result.Simplify();
        return result;
    }

    // ToString

    public override string ToString()
    {
        string text = $"{this.numerator}/ {this.denominator}";
        return text;
    }
}
