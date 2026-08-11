var rectangle1 = new Rectangle(5, 3);
// var calculator = new ShapeMeasurementsCalculator();

Console.WriteLine("Width is: " + rectangle1.Width);
Console.WriteLine("Height is: " + rectangle1.GetHeight());
Console.WriteLine("Area is: " + rectangle1.CalculateRectangleArea());
Console.WriteLine("Circumference is: " + rectangle1.CalculateCircumference());

class Rectangle
{
    const int NumberOfSides = 4;
    readonly int NumberOfSidesReadonly = 4;
    public readonly int Width;
    private int _height;
    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));   
    }
    public int GetHeight() => _height;
    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }
    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonePositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonePositive;
        }
        return length;
        
    }
    public int CalculateCircumference() => (Width + Height) * 2;
    public int CalculateRectangleArea() => Width * Height;  // Expression
}
// class ShapeMeasurementsCalculator
// {
//     public int CalculateRectangleCircumference(Rectangle rectangle)
//     {
//         return (rectangle.Width + rectangle.Height) * 2;
//     }
//     public int CalculateRectangleArea(Rectangle rectangle)
//     {
//         return rectangle.Width * rectangle.Height;
//     }
// }



