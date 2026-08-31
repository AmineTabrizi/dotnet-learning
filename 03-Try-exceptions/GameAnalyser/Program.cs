
using GameAnalyser.App;
using GameAnalyser.DataAccess;
using GameAnalyser.Loggin;
using GameAnalyser.UserInteraction;

var userInteractor = new ConsoleUserInteractor();
var app = new GameDataParserApp(
    userInteractor,
    new GamesPrinter(userInteractor), 
    new VideoGameDeserializer(userInteractor),
    new LocalFileReader());

var logger = new Logger("log.txt");
try
{
    app.Run();
}
catch(Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexpected error" + "and will have to be close.");
    logger.Log(ex);
}
Console.WriteLine("Press any key to close");
Console.ReadKey();
