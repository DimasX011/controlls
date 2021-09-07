using System;
using System.Collections.Generic;
using System.Text;
using MetricsAgent.AllRequestMetric;
using MetricsAgent.Controllers;
using MetricsAgent.DotnetMetricRepo;
using Microsoft.Extensions.Logging;
using Moq;
using MetricsAgent.Controllers.testclass;
using Xunit;
using Microsoft.AspNetCore.Mvc;


namespace TestMetricManager.TestAgentMetric
{
   public class DotnetMetricsControllerTest
    {

        public ILogger<DotnetMetricsController> logger;

        [Fact]
        public void Create_ShouldCall_Create_From_Repository_CpuMetric()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<IDotnetInterfaceRepository>();
            var controller = new DotnetMetricsController(repositorymock.Object, logger);
            controller.Create(request);
            repositorymock.Verify(repository => repository.Create(It.IsAny<DotnetMetric>()), Times.Once);
        }
        [Fact]
        public void GetAll()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            var repositorymock = new Mock<IDotnetInterfaceRepository>();
            var controller = new DotnetMetricsController(repositorymock.Object, logger);
            repositorymock.Setup(controller => controller.Create(It.IsAny<DotnetMetric>())).Verifiable();
            var result = controller.GetAll();
            repositorymock.Verify(controller => controller.GetAll(), Times.Once);
        }
        [Fact]
        public void GetMetricsFromAgentAllCluster_ReturnsOk()
        {
            TimeSpan time = new TimeSpan(9);
            TimeSpan timeone = new TimeSpan(6);
            var repositorymock = new Mock<IDotnetInterfaceRepository>();
            var controller = new DotnetMetricsController(repositorymock.Object, logger);
            var result = controller.GetMetricsDotnetMetricsAgent(time, timeone);
            Assert.IsAssignableFrom<IActionResult>(result);
        }


        [Fact]
        public void TryToInsertAndRead()
        {
            var repositorymock = new Mock<IDotnetInterfaceRepository>();
            var controller = new DotnetMetricsController(repositorymock.Object, logger);
            var result = controller.TryToInsertAndRead();
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
        
}
