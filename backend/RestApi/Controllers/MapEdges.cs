using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapEdgesController : ControllerBase
    {
        private readonly ILogger<MapEdgesController> _logger;
        private readonly PlaceContext _db;

        public MapEdgesController(ILogger<MapEdgesController> logger, PlaceContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet(Name = "GetMapEdges")]
        public IEnumerable<MapEdges> Get()
        {
            return _db.MapEdges.ToArray();
        }
    }
}
