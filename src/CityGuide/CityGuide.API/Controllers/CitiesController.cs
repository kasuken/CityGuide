using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityGuide.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CityGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {

        private readonly ILogger<CitiesController> _logger;

        public CitiesController(ILogger<CitiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new City
            {
                ID = Guid.NewGuid(),
                Name = $"City {index}",
                Description = $"A long description for the city",
                isActive = true,
                isFeatured = false,
                PublishedAt = DateTime.Now.AddDays(-365)
            })
            .ToArray();
        }

    }
}
