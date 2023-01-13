using DataInitializer;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;
        private readonly PlaceContext _db;

        public AddressController(ILogger<AddressController> logger, PlaceContext db)
        {
            _logger = logger;
            _db = db;
        }

        //[HttpPost(Name = "PostAddress")]
        //[Route("/{lat}/{lon}")]
        //public IEnumerable<Category> Post(double lat, double lon)
        //{
        //    return _db.Places.ToArray();
        //}
    }
}
