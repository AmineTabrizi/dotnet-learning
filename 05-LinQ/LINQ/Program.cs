var words = new List<string> {"b", "ccc", "WDss", "a"};
var wordsLongerThan3Letters = words.Where(word => word.Length > 3);

var numbers = new int[] {1, 2, 3, 4, 5, 6};
var oddNumbers = numbers.Where(number => number % 2 == 1);

Console.ReadKey();

