using System;
using System.Collections.Generic;
using System.Text;
using MetricsAgent.Controllers;
using MetricsAgent.DotnetMetricRepo;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace TestMetricManager.TestAgentMetric
{
   public class DotnetMetricsControllerTest
    {
        private DotnetMetricsController controller;
        private Mock<IDotnetInterfaceRepository> mock;
        private readonly ILogger<AgentMetricsController> _logger;
        public DotnetMetricsControllerTest()
        {
            mock = new Mock<IDotnetInterfaceRepository>();

            controller = new DotnetMetricsController(mock.Object, _logger);
        }
        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            // устанавливаем параметр заглушки
            // в заглушке прописываем что в репозиторий прилетит CpuMetric объект
            mock.Setup(repository => repository.Create(It.IsAny<DotnetMetric>())).Verifiable();

            // выполняем действие на контроллере
            var result = controller.Create(new MetricsAgent.AllRequestMetric.CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // проверяем заглушку на то, что пока работал контроллер
            // действительно вызвался метод Create репозитория с нужным типом объекта в параметре
            mock.Verify(repository => repository.Create(It.IsAny<DotnetMetric>()), Times.AtMostOnce());
        }
    }
}
