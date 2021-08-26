using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricsAgent.DotnetMetricRepo;
using MetricsAgent.AllRequestMetric;
using MetricsAgent.AllRequestMetric.Response;
using Microsoft.Extensions.Logging;

namespace MetricsAgent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DotnetMetricsController : ControllerBase
    {

        private IDotnetInterfaceRepository repository;
        private readonly ILogger<AgentMetricsController> _logger;

        public DotnetMetricsController(IDotnetInterfaceRepository repository, ILogger<AgentMetricsController> logger)
        {
            _logger = logger;
            this.repository = repository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateRequest request)
        {
            _logger.LogDebug("Создание запроса", request);
            repository.Create(new DotnetMetric
            {
                Time = request.Time,
                Value = request.Value
            });

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

        [HttpGet("api/metrics/dotnet/errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsDotnetMetricsAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogDebug("Создание запроса", fromTime, toTime);
            return Ok();
        }
    }
}
