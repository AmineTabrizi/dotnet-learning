const string filePath = "file.txt";
var writer = new FileWriter(filePath);
writer.Write("Some text.");
writer.Write("Some other text.");

Console.WriteLine("Press any key to close.");
Console.ReadKey();

class FileWriter
{
    private readonly StreamWriter _streamWriter;

    public FileWriter(string filePath)
    {
        _streamWriter = new StreamWriter(filePath, true);
    }
    public void Write(string text)
    {
        _streamWriter.WriteLine(text);
        _streamWriter.Flush();
    }
}