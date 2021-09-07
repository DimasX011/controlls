using System;
using System.Collections.Generic;
using System.Text;
using MetricsAgent.AllRequestMetric;
using MetricsAgent.Controllers;
using MetricsAgent.HddMetricRepo;
using Microsoft.Extensions.Logging;
using Moq;
using MetricsAgent.Controllers.testclass;
using Xunit;
using Microsoft.AspNetCore.Mvc;


namespace TestMetricManager.TestAgentMetric
{
    public class HddMetricControllerTest
    {
        public ILogger<HddMetricsController> logger;

        [Fact]
        public void Create_ShouldCall_Create_From_Repository_CpuMetric()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<IhddMetricInterface>();
            var controller = new HddMetricsController(repositorymock.Object,logger );
            controller.Create(request);
            repositorymock.Verify(repository => repository.Create(It.IsAny<HddMetric>()), Times.Once);
        }

        [Fact]
        public void GetAll()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<IhddMetricInterface>();
            var controller = new HddMetricsController(repositorymock.Object, logger);
            repositorymock.Setup(repository => repository.Create(It.IsAny<HddMetric>())).Verifiable();
            var result = controller.GetAll();
            repositorymock.Verify(repository => repository.GetAll(), Times.Once);
        }

        [Fact]
        public void GetMetricsFromAgentAllCluster_ReturnsOk()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<IhddMetricInterface>();
            var controller = new HddMetricsController(repositorymock.Object, logger);
            TimeSpan time = new TimeSpan(9);
            TimeSpan timeone = new TimeSpan(6);
            var result = controller.GetMetricsHddMetricsAgent(time, timeone);
            Assert.IsAssignableFrom<IActionResult>(result);
        }


        [Fact]
        public void TryToInsertAndRead()
        {
            var repositorymock = new Mock<IhddMetricInterface>();
            var controller = new HddMetricsController(repositorymock.Object, logger);
            var result = controller.TryToInsertAndRead();
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
