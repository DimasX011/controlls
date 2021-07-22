using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        private readonly ILogger<AgentController> _logger;

        public AgentController(ILogger<AgentController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в CpuMetricsController");
        }


        [HttpGet]
        public IActionResult Check()
        {
            return Ok();
        }
        
        
        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            _logger.LogInformation("Регистрация пользователя",agentInfo);
            return Ok();
        }

        [HttpGet("Read")]
        public IActionResult RegisterList([FromBody] AgentInfo agentInfo)
        {
            _logger.LogInformation("Зарегистрированные пользователи", agentInfo.Get());
            return Ok(agentInfo.Get());
        }


        [HttpPut("enable/{agentId}")]
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            _logger.LogInformation("Действительный идентификатор пользователя", agentId);
            return Ok();
        }

        [HttpPut("disable/{agentId}")]
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            _logger.LogInformation("Недействительный идентификатор пользователя", agentId);
            return Ok();
        }

        [HttpGet("api/metrics/cpu/from/{fromTime}/to/{toTime}")]
        public IActionResult CPUMetricsController([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Загрузка процессора каждую секунду", fromTime, toTime);
            return Ok();
        }
      
        [HttpGet("api/metrics/dotnet/errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromDotNet([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Метрики работы CLR для ASP.NET Core", fromTime, toTime);
            return Ok();
        }

        [HttpGet("api/metrics/network/from/{fromTime}/to/{toTime}")]
        public IActionResult GetmetricsFromNetworks([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Пропускная способность сети", fromTime, toTime);
            return Ok();
        }

        [HttpGet("api/metrics/hdd/left/from/{hdd_volume}")]
        public IActionResult GetMetricsFromHdd([FromRoute] long hdd_volume)
        {
            _logger.LogInformation("Использование пространства жёсткого диска", hdd_volume);
            return Ok();
        }

        [HttpGet("api/metrics/ram/available/from/{ram_volume}")]
        public IActionResult GetMetricsFromRam([FromRoute] int ram_volume)
        {
            _logger.LogInformation("Использование оперативной памяти", ram_volume);
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
