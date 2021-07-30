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

        [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

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