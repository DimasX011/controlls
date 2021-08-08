using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {

        [HttpGet]
        public IActionResult Check()
        {
            return Ok();
        }
        
        
        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            return Ok();
        }

        [HttpGet("Read")]
        public IActionResult RegisterList([FromBody] AgentInfo agentInfo)
        {
            return Ok(agentInfo.Get());
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

        [HttpGet("api/metrics/cpu/from/{fromTime}/to/{toTime}")]
        public IActionResult CPUMetricsController([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
      
        [HttpGet("api/metrics/dotnet/errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromDotNet([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("api/metrics/network/from/{fromTime}/to/{toTime}")]
        public IActionResult GetmetricsFromNetworks([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("api/metrics/hdd/left/from/{hdd_volume}")]
        public IActionResult GetMetricsFromHdd([FromRoute] long hdd_volume)
        {
            return Ok();
        }

        [HttpGet("api/metrics/ram/available/from/{ram_volume}")]
        public IActionResult GetMetricsFromRam([FromRoute] int ram_volume)
        {
            return Ok();
        }

    }

    public class AgentInfo
    {
        List<AgentInfo> agents = new List<AgentInfo>();

        public int AgentId { get; }

        public Uri AgentAddress { get; }

        private readonly AgentInfo agent;

        public AgentInfo()
        {
            agents.Add(agent);
        }

        public List<AgentInfo> Get()
        {
            return agents;
        }
    }

}
