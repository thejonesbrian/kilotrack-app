using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace kilotrack.Web.Controllers
{
    [ApiController]
    public class WeightController : ControllerBase
    {
        private readonly ILogger<WeightController> _logger;

        public WeightController(ILogger<WeightController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/weight")]
        public ActionResult GetWeight()
        {
            return Ok("Your weight is.....!");
        }
    }
}
