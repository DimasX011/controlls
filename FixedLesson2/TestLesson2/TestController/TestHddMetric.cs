using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestLesson2.TestController
{
    public class TestHddMetric
    {

        [Fact]
        public void GetMetricsFromHdd_ReturnsOk()
        {
            //Arrange
            var cpu = new Lesson2.Controllers.HddMetricController();
            long hdd = 2048;

            //Act
            var result = cpu.GetMetricsFromHdd(hdd);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
