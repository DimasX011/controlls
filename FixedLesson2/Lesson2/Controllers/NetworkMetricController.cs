using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetworkMetricController : ControllerBase
    {
        [HttpGet("api/metrics/network/from/{fromTime}/to/{toTime}")]
        public IActionResult GetmetricsFromNetworks([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
