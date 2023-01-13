using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlaceController : ControllerBase
    {
        private readonly ILogger<PlaceController> _logger;
        private readonly PlaceContext _db;

        public PlaceController(ILogger<PlaceController> logger, PlaceContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet(Name = "GetPlaces")]
        public IEnumerable<Place> Get()
        {
            return _db.Places.ToArray();
        }
    }
}