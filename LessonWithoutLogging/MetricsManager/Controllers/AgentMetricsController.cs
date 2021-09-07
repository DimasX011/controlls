
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace MetricsManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentMetricsController : ControllerBase
    {
        private readonly ILogger<AgentMetricsController> _logger;

        
        public AgentMetricsController(ILogger<AgentMetricsController> logger)
        {
            _logger = logger;
        }
        

        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            return Ok();
           
        }

        [HttpPut("enable/{agentId}")]
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpPut("disable/{agentId}")]
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

    }

}
