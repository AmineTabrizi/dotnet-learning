namespace GameAnalyser.App
{
    public class GameDataParserApp
    {
        private readonly IUserInteractor _userInteractor;
        private readonly IGamesPrinter _gamesPrinter;
        private readonly IVideoGamesDeserializer _videoGameDeserializer;
        private readonly IFileReader _fileReader;

        public GameDataParserApp(IUserInteractor userInteractor,
        IGamesPrinter gamesPrinter, 
        IVideoGamesDeserializer videoGamesDeserializer,
        IFileReader fileReader)
        {
            _userInteractor = userInteractor;
            _gamesPrinter = gamesPrinter;
            _videoGameDeserializer = videoGamesDeserializer;
            _fileReader = fileReader;
        }

        public void Run()
        {
            string fileName = _userInteractor.ReadValidFilePath();
            var fileContents = _fileReader.Read(fileName);
            List<VideoGame> videoGames = _videoGameDeserializer.DeserializeFrom(fileName, fileContents);
            _gamesPrinter.Print(videoGames);
        }
    }

}