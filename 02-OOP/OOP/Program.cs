var names = new Names();
var path = names.BuildFilePath();

if (File.Exists(path))
{
    Console.WriteLine("Name file already exists. Loading names.");
    names.ReadFromTextFile();
}
else
{
    Console.WriteLine("Names file does not exist yet.");

    names.AddName("Amin");
    names.AddName("not a valid name");
    names.AddName("mohammad");
    names.AddName("123 not a valid name");

    Console.WriteLine("Saving names to File...");
    names.WriteToTextFile();
}
Console.WriteLine(names.Format());
Console.ReadKey();

class NamesValidator
{
    public bool IsValid(string name)
    {
        return name.Length >= 2 && name.Length < 25 && char.IsUpper(name[0]) && name.All(char.IsLetter);
    }
}

class StringTextualRepository
{
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Separator).ToList();
        
    }
    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Separator, strings));
    }
}

class Names()
{
    private List<string> _name = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();
    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            _name.Add(name);
        }
    }
    public string BuildFilePath()
    {
        return "names.txt";
    }
    public string Format()
    {
        return string.Join(Environment.NewLine, _name);
    }
}