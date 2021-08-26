using System;
using System.Collections.Generic;
using System.Text;
using MetricsAgent.Controllers;
using MetricsAgent.RamMetricRepo;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace TestMetricManager.TestAgentMetric
{
    public class RamMetricControllerTest
    {
        private RamMetricsController controller;
        private Mock<IRamMetricRepository> mock;
        private readonly ILogger<AgentMetricsController> _logger;
        public RamMetricControllerTest()
        {
            mock = new Mock<IRamMetricRepository>();

            controller = new RamMetricsController(mock.Object, _logger);
        }
        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            // устанавливаем параметр заглушки
            // в заглушке прописываем что в репозиторий прилетит CpuMetric объект
            mock.Setup(repository => repository.Create(It.IsAny<RamMetric>())).Verifiable();

            // выполняем действие на контроллере
            var result = controller.Create(new MetricsAgent.AllRequestMetric.CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // проверяем заглушку на то, что пока работал контроллер
            // действительно вызвался метод Create репозитория с нужным типом объекта в параметре
            mock.Verify(repository => repository.Create(It.IsAny<RamMetric>()), Times.AtMostOnce());
        }
    }
}
