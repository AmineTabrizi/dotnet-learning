var list = new List<int>();

list.Add(1);
list.Add(2);
list.Add(3);

Console.WriteLine(list.Count);
Console.WriteLine(list.Capacity);

list.TrimExcess();

Console.WriteLine(list.Count);
Console.WriteLine(list.Capacity);