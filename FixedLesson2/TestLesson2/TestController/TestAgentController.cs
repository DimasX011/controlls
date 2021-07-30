
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestLesson2.TestController
{
    public class TestAgentController
    {
        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //Arrange
            var agent = new consoleApiApp.Controllers.AgentController();
            var agentId = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = agent.GetMetricsFromAgent(agentId, fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void RegisterAgent_ReturnsOk()
        {
            //Arrange
            var agent = new consoleApiApp.Controllers.AgentController();
            var info = new consoleApiApp.Controllers.AgentInfo();

            //Act
            var result = agent.RegisterAgent(info);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void RegisterList_ReturnsOk()
        {
            //Arrange
            var agent = new consoleApiApp.Controllers.AgentController();
            var info = new consoleApiApp.Controllers.AgentInfo();

            //Act
            var result = agent.RegisterList(info);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void EnableAgentById_ReturnsOk()
        {
            //Arrange
            var agent = new consoleApiApp.Controllers.AgentController();
            var id = 1;

            //Act
            var result = agent.EnableAgentById(id);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentById_ReturnsOk()
        {
            //Arrange
            var agent = new consoleApiApp.Controllers.AgentController();
            var id = 1;

            //Act
            var result = agent.DisableAgentById(id);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
