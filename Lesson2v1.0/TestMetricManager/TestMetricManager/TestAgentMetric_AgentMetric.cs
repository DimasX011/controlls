using System;
using System.Collections.Generic;
using System.Text;

using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace TestMetricManager.TestMetricManager
{
    public class TestAgentMetric_AgentMetric
    {
        private MetricsAgent.Controllers.AgentMetricsController controlleragent;
        private MetricsAgent.AgentInfo Agent;
        private Uri adress;
        private int Agentid;

        public TestAgentMetric_AgentMetric()
        {
            controlleragent = new AgentMetricsController();
        }


        [Fact]
        public void RegisterAgentt_ReturnsOk()
        {
            //Arrange
            var info = new MetricsAgent.AgentInfo(Agentid,adress);
            //Act
            var result = controlleragent.RegisterAgent(info);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void ReadAllRegistred_ReturnsOk()
        {
            //Act
            var result = controlleragent.ReadAllRegistred();
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
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
