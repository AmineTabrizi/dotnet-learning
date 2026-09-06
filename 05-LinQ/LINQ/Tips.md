# Deferred Execution

**Deferred execution** means a LINQ query is created now but **executed later**, when its result is enumerated.

```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };

var evenNumbers = numbers.Where(n => n % 2 == 0);

numbers.Add(6);

foreach (var n in evenNumbers)
    Console.WriteLine(n);
```

Output:

```text
2
4
6
```

The query runs when `foreach` enumerates it, not when `Where()` is called.

To execute it immediately, use:

```csharp
var evenNumbers = numbers
    .Where(n => n % 2 == 0)
    .ToList();
```

### Remember

> **LINQ query = execute later**
> **`ToList()` / `ToArray()` = execute now**

=========

all properties in anonymous types are readonly.
exmaple of anonymous: new {Name = "Jacky", Type = "Dog"};