# C# Fundamentals — Quick Notes

## 1. Variables & Types

```csharp
int age = 20;
double price = 10.5;
decimal salary = 1500.50m;
string name = "Amin";
bool isActive = true;
var number = 10;
```

* `var` lets the compiler infer the type.
* `const` is used for values that cannot change.

---

## 2. Input / Output

```csharp
Console.WriteLine("Hello");
var input = Console.ReadLine();
```

`Console.ReadLine()` always returns a `string`.

### String → Number

```csharp
int number = int.Parse(input);
```

If the input is invalid → Exception.

Safer for user input:

```csharp
if (int.TryParse(input, out int number))
{
    // Conversion succeeded
}
else
{
    // Invalid input
}
```

`TryParse` returns `true` or `false` depending on whether the conversion succeeds.

---

## 3. Operators

```text
+  -  *  /  %
== != > < >= <=
&& || !
```

`%` → returns the remainder of a division.

---

## 4. Conditions

```csharp
if (condition)
{
}
else if (condition)
{
}
else
{
}
```

### Switch

```csharp
switch (choice)
{
    case "A":
        break;

    case "B":
        break;

    default:
        break;
}
```

---

## 5. Loops

### for

Use when you need the index:

```csharp
for (int i = 0; i < items.Count; i++)
{
    Console.WriteLine(items[i]);
}
```

### foreach

Use when you only need the elements:

```csharp
foreach (var item in items)
{
    Console.WriteLine(item);
}
```

### while

Runs while the condition is `true`:

```csharp
while (condition)
{
}
```

### do-while

Runs at least once:

```csharp
do
{
}
while (condition);
```

---

## 6. Lists

```csharp
var numbers = new List<int>();

numbers.Add(10);
numbers.Remove(10);
numbers.RemoveAt(0);

int count = numbers.Count;

var first = numbers[0];
```

⚠️ Index starts from `0`.

```text
User sees:   1  2  3
List index:  0  1  2
```

---

## 7. Methods

Methods help separate logic and avoid repetition.

### Basic Method

```csharp
void SayHello()
{
    Console.WriteLine("Hello");
}
```

### Parameters

```csharp
void Greet(string name)
{
    Console.WriteLine($"Hello {name}");
}
```

### Return Value

```csharp
int Add(int a, int b)
{
    return a + b;
}
```

---

## 8. Strings

```csharp
string name = "Amin";

Console.WriteLine(name.Length);
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());
```

### String Interpolation

```csharp
Console.WriteLine($"Hello {name}");
```

Usually cleaner than:

```csharp
"Hello " + name
```

---


## 9. Important C# Concepts

```text
string      → text
int         → integer number
double      → floating-point number
decimal     → precise decimal numbers, commonly used for money
bool        → true / false

List<T>     → collection of elements
var         → type inference
null        → absence of a value
```

---

# 🧠 Rules to Remember

* Index starts from `0`.
* `Console.ReadLine()` returns a `string`.
* Use `TryParse` for potentially invalid user input.
* `for` → when the index matters.
* `foreach` → when you only need the elements.
* `do-while` → executes at least once.
* `List<T>` → a mutable collection.
* Method → separates reusable logic.
* Class → a blueprint.
* Object → an instance of a class.
* `new` → creates an object.

