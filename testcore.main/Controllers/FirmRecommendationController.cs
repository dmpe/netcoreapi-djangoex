using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testcore.DBModel;
using Microsoft.EntityFrameworkCore;

namespace testcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirmRecommendationController : ControllerBase
    {
        private DbContext context = new da3dqj9mkmfi1gContext();
        private readonly ILogger<FirmRecommendationController> _logger;

        // The Web API will only accept tokens 1) for users, and 2) having the access_as_user scope for this API
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        public FirmRecommendationController(ILogger<FirmRecommendationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IQueryable<MainFirmRecommendation> Get()
        {
            return context.Set<MainFirmRecommendation>();
        }
    }
}
