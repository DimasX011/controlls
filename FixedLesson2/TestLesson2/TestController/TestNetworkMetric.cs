using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestLesson2.TestController
{
   public class TestNetworkMetric
    {

        [Fact]
        public void GetmetricsFromNetworks_ReturnsOk()
        {
            //Arrange
            var cpu = new Lesson2.Controllers.NetworkMetricController();
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = cpu.GetmetricsFromNetworks(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
