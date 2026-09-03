var amin = new Person {Name = "Amin", YearOfBirth = 2007};
var amir = new Person {Name = "Amir", YearOfBirth = 2006};

PrintInOrder(10, 5);
PrintInOrder("aaa", "bb");
PrintInOrder(amin, amir);


void PrintInOrder<T>(T first, T second) where T : IComparable<T>
{
    if (first.CompareTo(second) > 0)
    {
        Console.WriteLine($"{second}, {first}");
    }
    else
    {
        Console.WriteLine($"{first}, {second}");
    }
}

public class Person : IComparable<Person>
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    public override string ToString() => $"{Name} born in ({YearOfBirth})";
    public int CompareTo(Person other)
    {
        if (YearOfBirth < other.YearOfBirth)
        {
            return -1;
        }
        else if (YearOfBirth > other.YearOfBirth)
        {
            return 1;
        }
        return 0;
    }
}