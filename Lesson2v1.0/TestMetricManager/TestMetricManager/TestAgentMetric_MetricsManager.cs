using System;
using System.Collections.Generic;
using System.Text;

using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace TestMetricManager.TestMetricManager
{
    public class TestAgentMetric_MetricsManager
    {
        private MetricsManager.Controllers.AgentMetricsController controllermanager;
      

        public TestAgentMetric_MetricsManager()
        {
            controllermanager = new AgentMetricsController();
        }


        [Fact]
        public void RegisterAgent_ReturnsOk()
        {
            //Arrange
            var info = new MetricsManager.AgentInfo();
            //Act
            var result = controllermanager.RegisterAgent(info);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }


        [Fact]
        public void EnableAgentById_ReturnsOk()
        {
            //Arrange
            int info = 2;
            //Act
            var result = controllermanager.EnableAgentById(info);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentById_ReturnsOk()
        {
            //Arrange
            int info = 5;
            //Act
            var result = controllermanager.DisableAgentById(info);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
