using OOP.DataAccess;
// using System.Diagnostics;

// var stopwatch = Stopwatch.StartNew();

// for(int i = 0; i < 1000; i++)
// {
//     Console.WriteLine($"Loop number {i}");
// }
// stopwatch.Stop();
// Console.WriteLine("Time in ms: " + stopwatch.ElapsedMilliseconds);


var names = new Names();
var path = new NamesFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringTextualRepository();

if (File.Exists(path))
{
    Console.WriteLine("Name file already exists. Loading names.");
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not exist yet.");

    names.AddName("Amin");
    names.AddName("not a valid name");
    names.AddName("mohammad");
    names.AddName("123 not a valid name");

    Console.WriteLine("Saving names to File...");
    stringsTextualRepository.Write(path, names.All);
}
Console.WriteLine(new NamesFormatter().Format(names.All));
Console.ReadKey();

