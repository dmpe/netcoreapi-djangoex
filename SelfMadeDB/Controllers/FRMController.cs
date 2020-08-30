using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfMadeDB.DBModel;

namespace SelfMadeDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FRMController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FRMController> _logger;

        // The Web API will only accept tokens 1) for users, and 2) having the access_as_user scope for this API
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        public FRMController(ILogger<FRMController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FirmRecommendations> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new FirmRecommendations
            {
                StartingDate = DateTime.Now.AddDays(index),
                Positioning = rng.Next(-20, 55).ToString(),
                Description = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
