

var seasonmonth = int.Parse(Console.ReadLine());
Console.WriteLine(GetSeason(seasonmonth));

string GetSeason(int month)
{
    return month switch
    {
        1 or 2 or 12 => "Winter",
        3 or 4 or 5 => "Spring",
        6 or 7 or 8 => "Summer",
        9 or 10 or 11 => "Autumn",
        _ => "Invalid Month!",
    };
}