
Type type = typeof(Person);

var properties = type.GetProperties();

foreach (var property in properties)
{
    Console.WriteLine(property.Name);
}

[Author("Amin")]
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}


public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}
class Person
{
    public string Name { get; set; }

    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}
