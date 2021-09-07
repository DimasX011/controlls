using System;
using System.Collections.Generic;
using System.Text;
using MetricsAgent.Controllers;
using MetricsAgent.NetworkMetricRepo;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using MetricsAgent.Controllers.testclass;
using MetricsAgent.AllRequestMetric;
using Microsoft.AspNetCore.Mvc;

namespace TestMetricManager.TestAgentMetric
{
    public class NetworkMetricsControllerTest
    {

        public ILogger<NetworkMetricsController> logger;

        [Fact]
        public void Create_ShouldCall_Create_From_Repository_NetworkMetric()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<INetworkMetricRepoitory>();
            var controller = new NetworkMetricsController(repositorymock.Object, logger);
            controller.Create(request);
            repositorymock.Verify(repository => repository.Create(It.IsAny<NetworkMetric>()), Times.Once);
        }

        [Fact]
        public void GetAll()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<INetworkMetricRepoitory>();
            var controller = new NetworkMetricsController(repositorymock.Object, logger);
            repositorymock.Setup(repository => repository.Create(It.IsAny<NetworkMetric>())).Verifiable();
            var result = controller.GetAll();
            repositorymock.Verify(repository => repository.GetAll(), Times.Once);
        }

        [Fact]
        public void GetMetricsFromAgentAllCluster_ReturnsOk()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<INetworkMetricRepoitory>();
            var controller = new NetworkMetricsController(repositorymock.Object, logger);
            TimeSpan time = new TimeSpan(9);
            TimeSpan timeone = new TimeSpan(6);
            var result = controller.GetMetricsNetworkMetricsManager(time, timeone);
            Assert.IsAssignableFrom<IActionResult>(result);
        }


        [Fact]
        public void TryToInsertAndRead()
        {
            var repositorymock = new Mock<INetworkMetricRepoitory>();
            var controller = new NetworkMetricsController(repositorymock.Object, logger);
            var result = controller.TryToInsertAndRead();
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
