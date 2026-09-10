var point1 = new Point(10, 15);

var point2 = new Point(10, 15);

Console.WriteLine(point1.Equals(point2));

var pointMoved = point1 with {X = point1.X + 1};

// All Structs are sealed. (can not be inherited)
struct Point : IEquatable<Point>
{
    public int X {get; init; }
    public int Y {get; init; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Point other)
    {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
        return obj is Point point && Equals(point);
    }

    public override string ToString() => $"X: {X}, Y: {Y}";

    public static bool operator ==(Point point1, Point point2) => point1.Equals(point2);
    public static bool operator !=(Point point1, Point point2) => !point1.Equals(point2);

    public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);
}