using MetricsManager.Controllers;

using Xunit;
using Moq;
using System;
using MetricsManager.Controllers.testclass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace TestMetricManager.TestMetricManager
{
    public class TestManagerMetric_CpuMetric
    {
        
        public CpuMetricsController controller;
        public ILogger<CpuMetricsController> logger;
        
        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            int value = 2;
            TimeSpan time = new TimeSpan(5);
            TimeSpan timeone = new TimeSpan(7);
            var control = new CpuMetricsController(logger);
            var result= control.GetMetricsFromAgent(value, time, timeone);
            Assert.IsAssignableFrom<IActionResult>(result);
            
        }

        [Fact]
        public void GetMetricsFromAgentAllCluster_ReturnsOk()
        {
            TimeSpan time = new TimeSpan(9);
            TimeSpan timeone = new TimeSpan(6);
            var control = new CpuMetricsController(logger);
            var result = control.GetMetricsFromAllCluster(time, timeone);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        

    } 
}
