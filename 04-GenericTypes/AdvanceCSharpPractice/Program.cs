// var countryToCurrencyMapping = new Dictionary<string, string>();

// countryToCurrencyMapping.Add("USA", "USD");
// countryToCurrencyMapping.Add("Canada", "CAD");
// countryToCurrencyMapping.Add("Japan", "JPY");

// ways to show Dictionary values
var countryToCurrencyMapping = new Dictionary<string, string>
{
    ["USA"] = "USD",
    ["Canada"] = "CAD",
    ["Japan"] = "JPY"
};

// var countryToCurrencyMapping = new Dictionary<string, string>
// {
//     {"USA", "USD"},
//     {"Canada", "CAD"},
//     {"Japan", "JPY"}
// };

foreach (var country in countryToCurrencyMapping)
{
    Console.WriteLine($"Country: {country.Key}, Currency: {country.Value}");
}

countryToCurrencyMapping["UK"] = "GBP";
Console.WriteLine("Currency in Canada is " + countryToCurrencyMapping["Canada"]);