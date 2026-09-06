namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {1, 5, 2, 4, 8, 3};
            var numbersWith11 = numbers.Append(11);
            
            var words = new [] {"Amin", "sw", "Mary", "Mohsen", "Lary"};

            
            var orderedWordsDecs = words.OrderByDescending(word => word);
            var lastOrLargerLengthThan4 = words.LastOrDefault(word => word.Length > 2);
            var lastOfOrdered = words.OrderBy(word => word.Length).Last();
            var toUpperCase = words.Select(word => word.ToUpper());
            var numberedWords = words.Select((word, index) => $"{index + 1}. {word}");
            foreach(var word in numberedWords)
            {
                Console.WriteLine(word);
            }
            
            // Console.WriteLine("Numbers" + string.Join(", ", numbers));
            // Console.WriteLine("Numbers With 10:" + string.Join(", ", numbersWith10));
            // var oddNumbers = numbers.Where(number => number % 2 == 1);

            var orderedOddNumbers = numbersWith11.Where(
                number => number % 2 == 1).OrderBy(number => number);

            // Console.WriteLine("Odd Numbers ordered with 11: " + string.Join(", ", orderedOddNumbers));

            Console.ReadKey();
        }
    }
}