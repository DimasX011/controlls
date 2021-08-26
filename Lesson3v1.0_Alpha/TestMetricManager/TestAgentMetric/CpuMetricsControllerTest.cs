using MetricsAgent.Controllers;
using MetricsAgent.CpuMetricRepo;
using Moq;
using Xunit;
using System;
using Microsoft.Extensions.Logging;

namespace TestMetricManager.TestAgentMetric
{
    public class CpuMetricsControllerTest
    {
        private CpuMetricsController controller;
        private Mock<ICpuInterfaceRepository> mock;
        private readonly ILogger<AgentMetricsController> _logger;
        public CpuMetricsControllerTest()
        {
            mock = new Mock<ICpuInterfaceRepository>();

            controller = new CpuMetricsController(mock.Object, _logger);
        }
        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            // устанавливаем параметр заглушки
            // в заглушке прописываем что в репозиторий прилетит CpuMetric объект
            mock.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();

            // выполняем действие на контроллере
            var result = controller.Create(new MetricsAgent.AllRequestMetric.CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // проверяем заглушку на то, что пока работал контроллер
            // действительно вызвался метод Create репозитория с нужным типом объекта в параметре
            mock.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
        }
    }

   

}

