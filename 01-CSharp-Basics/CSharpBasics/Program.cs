// List<string> words = new List<string> ();

// Console.WriteLine(words.Count);
// words.Add("hello");

var words = new List<string>
{
    "one",
    "two",
};
var morewords = new[] {"three", "four", "five"};
words.AddRange(morewords);
Console.WriteLine("Index of element three is: " + words.IndexOf("three"));
Console.WriteLine("Contains 'seven'?: " + words.Contains("seven"));

words.Clear();
Console.WriteLine("Count of words after clear: " + words.Count);
foreach(var word in words)
{
    Console.WriteLine(word);
}
// for(int i = 0; i < words.Count; i++)
// {
//     Console.WriteLine(words[i]);
// }
Console.WriteLine("Removing an item: ");
// words.Remove("two");
words.RemoveAt(0);
foreach(var word in words)
{
    Console.WriteLine(word);
}




Console.ReadKey();

