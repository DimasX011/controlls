using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestLesson2.TestController
{
    public class TestRamMetric
    {
        [Fact]
        public void GetMetricsFromRam_ReturnsOk()
        {
            //Arrange
            var cpu = new Lesson2.Controllers.RamMetricController();
            int hdd = 2048;

            //Act
            var result = cpu.GetMetricsFromRam(hdd);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
