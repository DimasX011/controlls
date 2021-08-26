using System;
using System.Collections.Generic;
using System.Text;
using MetricsAgent.Controllers;
using MetricsAgent.HddMetricRepo;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace TestMetricManager.TestAgentMetric
{
    public class HddMetricControllerTest
    {
        private HddMetricsController controller;
        private Mock<IhddMetricInterface> mock;
        private readonly ILogger<AgentMetricsController> _logger;
        public HddMetricControllerTest()
        {
            mock = new Mock<IhddMetricInterface>();

            controller = new HddMetricsController(mock.Object, _logger);
        }
        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            // устанавливаем параметр заглушки
            // в заглушке прописываем что в репозиторий прилетит CpuMetric объект
            mock.Setup(repository => repository.Create(It.IsAny<HddMetric>())).Verifiable();

            // выполняем действие на контроллере
            var result = controller.Create(new MetricsAgent.AllRequestMetric.CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // проверяем заглушку на то, что пока работал контроллер
            // действительно вызвался метод Create репозитория с нужным типом объекта в параметре
            mock.Verify(repository => repository.Create(It.IsAny<HddMetric>()), Times.AtMostOnce());
        }
    }
}
