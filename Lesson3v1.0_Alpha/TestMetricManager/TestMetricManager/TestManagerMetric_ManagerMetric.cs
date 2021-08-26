using System;
using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Microsoft.Extensions.Logging;

namespace TestMetricManager.TestMetricManager
{
    public class TestManagerMetric_ManagerMetric
    {
        
        private AgentMetricsController controlleragent;
        /*
        private readonly ILogger<AgentMetricsController> _logger;

        public TestManagerMetric_ManagerMetric()
        {
            controlleragent = new AgentMetricsController(_logger);
        }
        */

        [Fact]
        public void RegisterAgentt_ReturnsOk()
        {
            //Arrange
            var info = new MetricsManager.AgentInfo();
            //Act
            var result = controlleragent.RegisterAgent(info);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult> (result);
        }


        [Fact]
        public void EnableAgentByIdd_ReturnsOk()
        {
            //Arrange
            int info = 2;
            //Act
            var result = controlleragent.EnableAgentById(info);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentByIdd_ReturnsOk()
        {
            //Arrange
            int info = 5;
            //Act
            var result = controlleragent.DisableAgentById(info);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
