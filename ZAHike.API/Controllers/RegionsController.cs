using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZAHike.API.Models.Domain;

namespace ZAHike.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
       public IActionResult GetAllRegions()
       {
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Eastern Cape Region",
                    Code = "EC",
                    Area = 168966,
                    Lat = -1.5777,
                    Long = 258.96,
                    Population = 6676691
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Northern Cape Region",
                    Code = "NC",
                    Area = 168966,
                    Lat = -1.5777,
                    Long = 258.96,
                    Population = 6676691
                }
            };
            return Ok(regions);
        }
    }
}
