
using System.Text.Json;

var person = new Person
{
    FirstName = "Amin",
    LastName = "Tabrizi",
    YearOfBirth = 2007
};

var asJson = JsonSerializer.Serialize(person);
Console.WriteLine("As JSON: ");
Console.WriteLine(asJson);

var personJson = "{\"FirstName\":\"Amin\",\"LastName\":\"Tabrizi\",\"YearOfBirth\":2007}";

var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

Console.WriteLine(personFromJson);

Console.ReadKey();

public class Person
{
    public string FirstName {get; set; }
    public string LastName {get; set; }
    public int YearOfBirth {get; set; }
}