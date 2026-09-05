namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {1, 5, 2, 4, 8, 3};
            var numbersWith11 = numbers.Append(11);
            
            // Console.WriteLine("Numbers" + string.Join(", ", numbers));
            // Console.WriteLine("Numbers With 10:" + string.Join(", ", numbersWith10));
            // var oddNumbers = numbers.Where(number => number % 2 == 1);

            var orderedOddNumbers = numbersWith11.Where(
                number => number % 2 == 1).OrderBy(number => number);

            Console.WriteLine("Odd Numbers ordered with 11: " + string.Join(", ", orderedOddNumbers));

            Console.ReadKey();
        }
    }
}