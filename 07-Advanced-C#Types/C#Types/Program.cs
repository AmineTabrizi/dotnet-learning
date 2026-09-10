var point1 = new Point(10, 15);

var point2 = new Point(10, 15);

Console.WriteLine(point1.Equals(point2));

var pointMoved = point1 with {X = point1.X + 1};

// All Structs are sealed. (can not be inherited)
struct Point
{
    public int X {get; init; }
    public int Y {get; init; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object? obj)
    {
        return obj is Point point && X == point.X && Y == point.Y;
    }

    public override string ToString() => $"X: {X}, Y: {Y}";
}