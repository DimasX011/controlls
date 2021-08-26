using MetricsAgent.Controllers;
using MetricsAgent.AgentmetricRepo;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using MetricsAgent.AgentMetricRepo;
using Xunit;
using Microsoft.Extensions.Logging;
using MetricsAgent.AllRequestMetric;

namespace TestMetricManager.TestAgentMetric
{
   public class AgentMetricsControllerTest
    {
        private AgentMetricsController controller;
        private Mock<IAgentIterfaceRepository> mock;
        private ILogger<AgentMetricsController> logger;
        public AgentMetricsControllerTest()
        {
            mock = new Mock<IAgentIterfaceRepository>();
            
        controller = new AgentMetricsController(mock.Object, logger);
        }
        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            var request = new CreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 };
            // устанавливаем параметр заглушки
            // в заглушке прописываем что в репозиторий прилетит CpuMetric объект
            mock.Setup(repository => repository.Create(It.IsAny<AgentMetric>())).Verifiable();

            // выполняем действие на контроллере
            var result = controller.Create(request);
            
            // проверяем заглушку на то, что пока работал контроллер
            // действительно вызвался метод Create репозитория с нужным типом объекта в параметре
            mock.Verify(repository => repository.Create(It.IsAny<AgentMetric>()), Times.AtMostOnce());
        }
    }
}
