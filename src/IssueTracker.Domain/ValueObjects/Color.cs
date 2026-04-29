using IssueTracker.Domain.Common;
using IssueTracker.Domain.Exceptions;

namespace IssueTracker.Domain.ValueObjects;

public class Color(string code) : ValueObject
{

    public static Color From(string code)
    {
        var color = new Color(code);
        if (!SupportedColours.Contains(color))
        {
            throw new UnsupportedColorException(code);
        }
        
        return color;
    }
    
    public static Color Red => new("#E05C4D");

    public static Color Orange => new("#D98B2B");

    public static Color Green => new("#4CAF50");

    public static Color Teal => new("#26A69A");

    public static Color Blue => new("#5C6BC0");

    public static Color Purple => new("#AB47BC");

    public static Color Grey => new("#78909C");
    
    public string Code { get; private set; } = string.IsNullOrWhiteSpace(code)?"#000000":code;
    public static implicit operator string(Color color)
    {
        return color.ToString();
    }

    public override string ToString()
    {
        return Code;
    }
    public static explicit operator Color(string code)
    {
        return From(code);
    }
    
    public static IEnumerable<Color> SupportedColours
    {
        get
        {
            yield return Red;
            yield return Orange;
            yield return Green;
            yield return Teal;
            yield return Blue;
            yield return Purple;
            yield return Grey;
        }
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }
}