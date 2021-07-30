using consoleApiApp.AgentReposity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {

        private IAgentMetricsRepository repository;

        private readonly ILogger<AgentController> _logger;

        public AgentController(ILogger<AgentController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в AgentController");
        }
        public AgentController(IAgentMetricsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var metrics = repository.GetByTimePeriod();

            var response = new AllAgentMetricsResponse()
            {
                agentMetrics = new List<AgentMetricsDto>()
            };

            foreach (var metric in metrics)
            {
                response.agentMetrics.Add(new AgentMetricsDto { Time = metric.Time, Value = metric.Value, Id = metric.Id });
            }

            return Ok(response);
        }

        [HttpGet("sql-read-write-test")]
        public IActionResult TryToInsertAndRead()
        {
            string connectionString = "Data Source=:memory:";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DROP TABLE IF EXISTS cpumetrics";
                    command.ExecuteNonQuery();
                    command.CommandText = @"CREATE TABLE cpumetrics(id INTEGER PRIMARY KEY,
                    value INT, time INT)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO cpumetrics(value, time) VALUES(10,1)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO cpumetrics(value, time) VALUES(50,2)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO cpumetrics(value, time) VALUES(75,4)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO cpumetrics(value, time) VALUES(90,5)";
                    command.ExecuteNonQuery();
                    string readQuery = "SELECT * FROM cpumetrics LIMIT 3";
                    var returnArray = new AgentDataClass[3];
                    command.CommandText = readQuery;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        var counter = 0;
                        while (reader.Read())
                        {
                            returnArray[counter] = new AgentDataClass
                            {
                                Id = reader.GetInt32(0),
                                Value = reader.GetInt32(1),
                                time = reader.GetDateTime(2)
                            };
                            counter++;
                        }
                    }
                    return Ok(returnArray);
                }
            }
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
