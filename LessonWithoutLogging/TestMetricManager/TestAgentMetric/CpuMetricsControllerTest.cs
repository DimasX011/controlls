using MetricsAgent.Controllers;
using MetricsAgent.CpuMetricRepo;
using Moq;
using Xunit;
using System;
using Microsoft.Extensions.Logging;
using MetricsAgent.AllRequestMetric;
using MetricsAgent.AgentMetricRepo;
using MetricsAgent.Controllers.testclass;
using Microsoft.AspNetCore.Mvc;

namespace TestMetricManager.TestAgentMetric
{
    public class CpuMetricsControllerTest
    {
    
        public ILogger<CpuMetricsController> customLogger;


        [Fact]
        public void Create_ShouldCall_Create_From_Repository_CpuMetric()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<ICpuInterfaceRepository>();
            var controller = new CpuMetricsController(repositorymock.Object,customLogger);
            controller.Create(request);
            repositorymock.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.Once);
        }

        [Fact]
        public void GetAll()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<ICpuInterfaceRepository>();
            var controller = new CpuMetricsController(repositorymock.Object, customLogger);
            repositorymock.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();
            controller.GetAll();
            repositorymock.Verify(repository => repository.GetAll(), Times.Once);
        }

        [Fact]
        public void GetMetricsFromAgentAllCluster_ReturnsOk()
        {
            TimeSpan time = new TimeSpan(9);
            TimeSpan timeone = new TimeSpan(6);
            var repositorymock = new Mock<ICpuInterfaceRepository>();
            var controller = new CpuMetricsController(repositorymock.Object, customLogger);
            var result = controller.GetMetricsCpuMetricAgent(time, timeone);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void TryToSqlLite()
        {
            var repositorymock = new Mock<ICpuInterfaceRepository>();
            var controller = new CpuMetricsController(repositorymock.Object, customLogger);
            var result = controller.TryToSqlLite();
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void TryToInsertAndRead()
        {
            var repositorymock = new Mock<ICpuInterfaceRepository>();
            var controller = new CpuMetricsController(repositorymock.Object, customLogger);
            var result = controller.TryToInsertAndRead();
            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }

   

}

