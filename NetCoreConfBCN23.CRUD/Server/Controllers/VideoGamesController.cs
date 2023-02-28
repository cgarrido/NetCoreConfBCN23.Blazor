using Microsoft.AspNetCore.Mvc;
using NetCoreConfBCN23.CRUD.Server.Services;
using NetCoreConfBCN23.CRUD.Shared;

namespace NetCoreConfBCN23.CRUD.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoGamesController : Controller
    {
        private readonly IVideoGamesRepository _videoGamesRepository;
        public VideoGamesController(IVideoGamesRepository videoGamesRepository)
        {
            _videoGamesRepository = videoGamesRepository ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public ActionResult Get()
        {
            Thread.Sleep(1000);
            return Ok(_videoGamesRepository.Get());
        }

        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            var videoGame = _videoGamesRepository.Get(id);
            if (videoGame == null) return NotFound();
            else return Ok(videoGame);
        }

        [HttpPut, HttpPost]
        public ActionResult AddOrUpdate(VideoGame obj)
        {
            var videoGame = _videoGamesRepository.Add(obj);
            return Ok(videoGame);
        }
    }
}
