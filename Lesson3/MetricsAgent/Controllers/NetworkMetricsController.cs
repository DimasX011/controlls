﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricsAgent.NetworkMetricRepo;
using MetricsAgent.AllRequestMetric;
using MetricsAgent.AllRequestMetric.Response;
using Microsoft.Extensions.Logging;
using System.Data.SQLite;

namespace MetricsAgent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetworkMetricsController : ControllerBase
    {
        private INetworkMetricRepoitory repository;
        private readonly ILogger<AgentMetricsController> _logger;
        public NetworkMetricsController(INetworkMetricRepoitory repository, ILogger<AgentMetricsController> logger)
        {
            _logger = logger;
            this.repository = repository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateRequest request)
        {
            _logger.LogDebug("Создание запроса", request);
            repository.Create(new NetworkMetric
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


        [HttpGet("sql-read-write-test")]
        public IActionResult TryToInsertAndRead()
        {
            string connectionString = "Data Source=:memory:";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DROP TABLE IF EXISTS dotnetmetrics";
                    command.ExecuteNonQuery();
                    command.CommandText = @"CREATE TABLE networkmetrics(id INTEGER PRIMARY KEY,
                    value INT, time INT)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO networkmetrics(value, time) VALUES(10,1)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO networkmetrics(value, time) VALUES(50,2)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO networkmetrics(value, time) VALUES(75,4)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO networkmetrics(value, time) VALUES(90,5)";
                    command.ExecuteNonQuery();
                    string readQuery = "SELECT * FROM networkmetrics LIMIT 3";
                    var returnArray = new GenerateData[3];
                    command.CommandText = readQuery;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        var counter = 0;
                        while (reader.Read())
                        {
                            returnArray[counter] = new GenerateData
                            {
                                Id = reader.GetInt32(0),
                                Value = reader.GetInt32(1),
                                Time = reader.GetInt64(2)
                            };

                            counter++;
                        }
                    }
                    return Ok(returnArray);
                }
            }
        }

        [HttpGet("api/metrics/network/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsNetworkMetricsManager([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogDebug("Создание запроса", fromTime, toTime);
            return Ok();
        }
    }
}
