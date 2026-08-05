

var words = new[] { "one", "two", "three", "four"};

// for(int i = 0; i < words.Length; i++)
// {
//     Console.WriteLine(words[i]);
// }

foreach(var word in words)
{
    Console.WriteLine(word);
}


// int[] numbers = new int[5];

// numbers[0] = 10;
// numbers[1] = 20;
// numbers[2] = 25;
// numbers[3] = 39;
// numbers[4] = 80;

// var firstfromend = numbers[^1];
// var Secondfromend = numbers[^2];
// Console.WriteLine("First From End: " + firstfromend);
// Console.WriteLine("Second From End: " + Secondfromend);

// int [] numbers = new int[] {4, 1, 6, 8, 2};


// var sum = 0;
// for(int i = 0; i < numbers.Length; i++)
// {
//     sum += numbers[i];
// }
// Console.WriteLine(sum);

// char[,] letters = new char[2, 3];

// letters[0, 0] = 'A';
// letters[0, 1] = 'B';
// letters[0, 2] = 'C';
// letters[1, 0] = 'D';
// letters[1, 1] = 'E';
// letters[1, 2] = 'F';

// var height = letters.GetLength(0);
// var width = letters.GetLength(1);
// Console.WriteLine("Height is " + height);
// Console.WriteLine("Width is " + width);

// for(int i = 0; i < height; i++)
// {
//     Console.WriteLine("i is: " + i);
//     for(int j = 0; j < width; j++)
//     {
//         Console.WriteLine("j is: " + j);
//         Console.WriteLine("Element is: " + letters[i, j]);
//     }
// }

// var letters2 = new char[,]
// {
//   {'A', 'B', 'C'},
//   {'D', 'E', 'F'},
// };








Console.ReadKey();



