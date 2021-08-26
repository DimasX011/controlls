using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricsAgent.AgentMetricRepo;
using MetricsAgent.AllRequestMetric;
using MetricsAgent.AllRequestMetric.Response;
using Microsoft.Extensions.Logging;

namespace MetricsAgent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentMetricsController : ControllerBase
    {
        private IAgentIterfaceRepository repository;
        private readonly ILogger<AgentMetricsController> _logger;
        public AgentMetricsController(IAgentIterfaceRepository repository, ILogger<AgentMetricsController> logger)
        {
            
            this.repository = repository;
            _logger = logger;

        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateRequest request)
        {
            
            repository.Create(new AgentMetric
            {
                Time = request.Time,
                Value = request.Value
            });
            _logger.LogDebug("Регистрация пользователя:", request);
            return Ok();
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var metrics = repository.GetAll();

            var response = new AllCpuMetricsResponse()
            {
                Metrics = new List<CpuMetricDto>()
            };

            foreach (var metric in metrics)
            {
                response.Metrics.Add(new CpuMetricDto { Time = metric.Time, Value = metric.Value, Id = metric.Id });
            }

            return Ok(response);
        }


        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            _logger.LogDebug("Регистрация пользователя:", agentInfo);
            return Ok();
        }

        [HttpGet("read")]
        public IActionResult ReadAllRegistred()
        {
            return Ok();
        }

        [HttpPut("enable/{agentId}")]
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            _logger.LogDebug("Регистрация пользователя:", agentId);
            return Ok();
        }

        [HttpPut("disable/{agentId}")]
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            _logger.LogDebug("Регистрация пользователя:", agentId);
            return Ok();
        }
    }
}
