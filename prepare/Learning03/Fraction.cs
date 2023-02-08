public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string input = $"{_top}/{_bottom}";
        return input;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}