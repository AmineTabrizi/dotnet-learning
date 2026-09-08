

for (var i = 0; i < 5; ++i)
{
    var person = new Person {Name = "Amin", Age = 19};
}

GC.Collect();
Console.WriteLine("Ready to close.");
Console.ReadKey();

class Person
{
    public string Name {get; init;}
    public int Age {get; init; }
    ~Person()
    {
        Console.WriteLine($"Person called {Name} is beign distructed.");
    }
}