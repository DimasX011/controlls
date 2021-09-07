using MetricsAgent.Controllers;
using MetricsAgent.AgentmetricRepo;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using MetricsAgent.AgentMetricRepo;
using Xunit;
using Microsoft.Extensions.Logging;
using MetricsAgent;
using MetricsAgent.AllRequestMetric;
using MetricsAgent.AllRequestMetric.Response;
using MetricsAgent.CpuMetricRepo;
using Microsoft.AspNetCore.Mvc;


namespace TestMetricManager.TestAgentMetric
{
   public class AgentMetricsControllerTest
    {
        public ILogger<AgentMetricsController> logger;

        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<IAgentIterfaceRepository>();
            var controller = new AgentMetricsController( repositorymock.Object, logger);
            controller.Create(request);
            repositorymock.Verify(repository => repository.Create(It.IsAny<AgentMetric>()), Times.Once);
        }

        [Fact]
        public void RegisterAgent()
        {
            var info = new AgentInfo();
            var repositorymock = new Mock<IAgentIterfaceRepository>();
            var controller = new AgentMetricsController(repositorymock.Object, logger);
            var result = controller.RegisterAgent(info);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetAll()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<IAgentIterfaceRepository>();
            var controller = new AgentMetricsController(repositorymock.Object, logger);
            repositorymock.Setup(repository => repository.Create(It.IsAny<AgentMetric>())).Verifiable();
            var result = controller.GetAll();
            repositorymock.Verify(repository => repository.GetAll(),Times.Once);
        }

        [Fact]
        public void EnableAgentById()
        {
            int id = 2;
            var repositorymock = new Mock<IAgentIterfaceRepository>();
            var controller = new AgentMetricsController(repositorymock.Object, logger);
            var result = controller.EnableAgentById(id);
            Assert.IsAssignableFrom<IActionResult>(result);

        }

        [Fact]
        public void DisableAgentById()
        {
            int id = 5;
            var repositorymock = new Mock<IAgentIterfaceRepository>();
            var controller = new AgentMetricsController(repositorymock.Object, logger);
            var result = controller.DisableAgentById(id);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void TryToInsertAndRead()
        {
            var repositorymock = new Mock<IAgentIterfaceRepository>();
            var controller = new AgentMetricsController(repositorymock.Object, logger);
            var result = controller.TryToInsertAndRead();
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}





















