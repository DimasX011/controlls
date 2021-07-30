using Lesson2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestLesson2.TestController
{
    public class TestCpuMetric
    {
        [Fact]
        public void GetMetricsFromAllCluster_ReturnsOk()
        {
            //Arrange
            var cpu = new Lesson2.Controllers.CpuMetricController();
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = cpu.GetMetricsFromAllCluster(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
        [Fact]
        public void CPUMetricsController_ReturnsOk()
        {
            //Arrange
            var cpu = new Lesson2.Controllers.CpuMetricController();
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = cpu.CPUMetricsController(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
