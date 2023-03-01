using NetCoreConfBCN23.CRUD.Shared;

namespace NetCoreConfBCN23.CRUD.Server.Services
{
    public interface IVideoGamesRepository
    {
        IEnumerable<VideoGame> Get();
        VideoGame? Get(int id);
        VideoGame Add(VideoGame obj);
        void Delete(int id);
    }
}
