// var invalidPersonObject = new Person("", -32);

// var emptyCollection = new List<int>();

int counter = 0;
RecursiveMethod(counter);

Console.ReadKey();



void RecursiveMethod(int counter)
{
    Console.WriteLine("I'm going to call my self.counter is: " + counter);
    if (counter < 10)
    {
        RecursiveMethod(counter + 1);
    }
}
// class Person
// {
//     public string Name {get; }
//     public int YearOfBirth {get; }
//     public Person(string name, int yearOfBirth)
//     {
//         if(name == string.Empty)
//         {
//             throw new ArgumentException("The name can not be empty.");
//         }
//         if(yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
//         {
//             throw new ArgumentException("The year of birth must be between 1900 & the current year.");
//         }
//         Name = name;
//         YearOfBirth = yearOfBirth;
//     }
// }
