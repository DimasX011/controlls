﻿using consoleApiApp.RamReposity;
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
    public class RamMetricsController : ControllerBase
    {
        internal IRamMetrics ramMetrics;

        private readonly ILogger<RamMetricsController> _logger;


        public RamMetricsController(ILogger<RamMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в AgentController");
        }

        public RamMetricsController(IRamMetrics ramMetrics)
        {
            this.ramMetrics = ramMetrics;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var metrics = ramMetrics.GetByTimePeriod();

            var response = new AllRamMetrics()
            {
                ramMetricDtos = new List<RamMetricDto>()
            };

            foreach (var metric in metrics)
            {
                response.ramMetricDtos.Add(new RamMetricDto { Time = metric.Time, Value = metric.Value, Id = metric.Id });
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
                    var returnArray = new RamData[3];
                    command.CommandText = readQuery;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        var counter = 0;
                        while (reader.Read())
                        {
                            returnArray[counter] = new RamData
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
    }
}
