using NetCoreConfBCN23.CRUD.Shared;

namespace NetCoreConfBCN23.CRUD.Server.Services
{
    public class VideoGamesRepository : IVideoGamesRepository
    {
        private static IList<VideoGame> _videoGames = new List<VideoGame>()
        { 
            new VideoGame() { Id = 1, Date = new DateOnly(2023, 1, 31), Name = "Hogwarts Legacy", Category = "CAT1"},
            new VideoGame() { Id = 2, Date = new DateOnly(2022, 5, 11), Name = "God of War Ragnarok", Category = "CAT85"},
            new VideoGame() { Id = 3, Date = new DateOnly(2022, 5, 6), Name = "Fifa 23", Category = "CAT1"},
            new VideoGame() { Id = 3, Date = new DateOnly(2021, 4, 5), Name = "Half Life 2", Category = "CAT123"},
            new VideoGame() { Id = 3, Date = new DateOnly(2012, 3, 12), Name = "Portal 2", Category = "CAT1"},
            new VideoGame() { Id = 3, Date = new DateOnly(2008, 2, 18), Name = "Red Dead Redemption 2", Category = "CAT25"},
            new VideoGame() { Id = 3, Date = new DateOnly(2023, 1, 1), Name = "Grand Theft Auto V", Category = "CAT36"}
        };

        public VideoGame Add(VideoGame obj)
        {
            if (!obj.Id.HasValue)
            {
                obj.Id = _videoGames.Select(v => v.Id).Max() + 1;
                obj.Name +="INSERT";
                _videoGames.Add(obj);
            }
            else
            {
                var found = _videoGames.Where(v => v.Id == obj.Id).FirstOrDefault();
                obj.Name += "UPD";
                _videoGames[_videoGames.IndexOf(found)] = obj;
            }

            return obj;
        }

        public void Delete(int id)
        {
            var obj = _videoGames.FirstOrDefault(v => v.Id == id);
            _videoGames.Remove(obj);
        }

        public IEnumerable<VideoGame> Get()
        {
            return _videoGames;
        }

        public VideoGame? Get(int id)
        {
            return _videoGames.Where(v => v.Id == id).FirstOrDefault();
        }
    }
}
