using MetricsManager.Controllers;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace TestMetricManager.TestMetricManager
{
    public class TestManagerMetric_AgentMetric
    {
        
   
        public ILogger<AgentMetricsController> _logger;


        [Fact]
        public void RegisterAgentt_ReturnsOk()
        {
            var info = new MetricsManager.AgentInfo();
            var control = new AgentMetricsController(_logger);
            var result = control.RegisterAgent(info);
            Assert.IsAssignableFrom<IActionResult>(result);
        }


        [Fact]
        public void EnableAgentByIdd_ReturnsOk()
        {
            int info = 2;
            var control = new AgentMetricsController(_logger);
            var result = control.EnableAgentById(info);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentByIdd_ReturnsOk()
        {
            int info = 2;
            var control = new AgentMetricsController(_logger);
            var result = control.DisableAgentById(info);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
