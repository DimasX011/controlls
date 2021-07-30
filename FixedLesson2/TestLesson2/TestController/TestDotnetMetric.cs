using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;


namespace TestLesson2.TestController
{
    public class TestDotnetMetric
    {

        [Fact]
        public void GetMetricsFromDotNet_ReturnsOk()
        {
            //Arrange
            var cpu = new Lesson2.Controllers.DotNetMetricController();
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = cpu.GetMetricsFromDotNet(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
