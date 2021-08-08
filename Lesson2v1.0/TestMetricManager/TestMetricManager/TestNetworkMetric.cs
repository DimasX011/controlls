using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestMetricManager.TestMetricManager
{
    public class TestNetworkMetric
    {
        private MetricsAgent.Controllers.DotnetMetricsController controller;

        public TestNetworkMetric()
        {
            controller = new MetricsAgent.Controllers.DotnetMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //Arrange
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetMetricsDotnetMetricsAgent(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
