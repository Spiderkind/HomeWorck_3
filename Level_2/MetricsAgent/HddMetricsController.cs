using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/Hdd")]
    [ApiController]
    public class HddMetricsController : ControllerBase
    {
        [HttpGet("left")]
        public IActionResult GetFreeSapce()
        {
            return Ok();
        }
    }
}
